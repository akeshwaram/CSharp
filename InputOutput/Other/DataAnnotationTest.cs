using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

public class SecretMessageDecoder
{
	public static async Task PrintSecretMessage(string url)
	{
		using HttpClient client = new HttpClient();

		string html = await client.GetStringAsync(url);

		var doc = new HtmlDocument();
		doc.LoadHtml(html);

		var points = new List<(int X, int Y, string Character)>();

		var rows = doc.DocumentNode.SelectNodes("//table//tr");

		if (rows == null)
		{
			Console.WriteLine("No rows found");
			return;
		}

		foreach (var row in rows)
		{
			var cells = row.SelectNodes("./td");

			if (cells == null || cells.Count < 3)
				continue;

			string xText = cells[0].InnerText.Trim();
			string character = cells[1].InnerText.Trim();
			string yText = cells[2].InnerText.Trim();

			if (!int.TryParse(xText, out int x))
				continue;

			if (!int.TryParse(yText, out int y))
				continue;

			points.Add((x, y, character));
		}

		Console.WriteLine($"Parsed {points.Count} points");

		if (points.Count == 0)
		{
			Console.WriteLine("No data found");
			return;
		}

		int maxX = points.Max(p => p.X);
		int maxY = points.Max(p => p.Y);

		var grid = new string[maxY + 1, maxX + 1];

		for (int y = 0; y <= maxY; y++)
		{
			for (int x = 0; x <= maxX; x++)
			{
				grid[y, x] = " ";
			}
		}

		foreach (var p in points)
		{
			grid[p.Y, p.X] = p.Character;
		}

		for (int y = 0; y <= maxY; y++)
		{
			for (int x = 0; x <= maxX; x++)
			{
				Console.Write(grid[y, x]);
			}
			Console.WriteLine();
		}
	}
}