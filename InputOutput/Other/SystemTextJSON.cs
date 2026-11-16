using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InputOutput.Other;
public class ApiResponse
{
	[JsonPropertyName("page")]
	public int Page { get; set; }

	[JsonPropertyName("total_pages")]
	public int TotalPages { get; set; }

	[JsonPropertyName("data")]
	public List<TVSeries> Data { get; set; }
}

public class TVSeries
{
	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("imdb_rating")]
	public string ImdbRating { get; set; }
}

public class JSONSolution
{
	public static async Task<string> GetTopRatedSeries()
	{
		using HttpClient client = new HttpClient();
		string baseUrl = "https://jsonmock.hackerrank.com/api/tvseries?page=";
		
		int currentPage = 1;
		int totalPages = 1;

		double maxRating = double.MinValue;
		string bestSeries = "";
		try
		{
			while (currentPage <= totalPages)
			{
				string json = await client.GetStringAsync(baseUrl + currentPage);
				var response = JsonSerializer.Deserialize<ApiResponse>(json);

				totalPages = response.TotalPages;

				foreach (var show in response.Data)
				{
					if (!double.TryParse(show.ImdbRating, out double rating))
						continue;

					if (rating > maxRating)
					{
						maxRating = rating;
						bestSeries = show.Name;
					}
					else if (rating == maxRating &&
							 string.Compare(show.Name, bestSeries, StringComparison.Ordinal) < 0)
					{
						bestSeries = show.Name;
					}
				}

				currentPage++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		return bestSeries;
	}

	public static async Task Main()
	{
		Console.WriteLine(await GetTopRatedSeries());
	}
}