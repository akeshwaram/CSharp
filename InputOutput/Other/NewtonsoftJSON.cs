using Newtonsoft.Json;
using System.Security;

namespace InputOutput.Other.Newtonsoft;

public class ApiResponse {
	[JsonProperty("page")]
	public int Page { get; set; }

	[JsonProperty("total_pages")]
	public int TotalPages { get; set; }

	[JsonProperty("data")]
	public List<TVSeries> Data { get; set; }
}


public class TVSeries
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("imdb_rating")]
	public float Rating { get; set; }
}

public class NewtonsoftSolution {

	public static async Task<string> GetBestRatedSeries()
	{
		string Base_URL = "https://jsonmock.hackerrank.com/api/tvseries?page=";

		using HttpClient client = new HttpClient();
		var currentPage = 1;
		var totalPages = 1;
		var maxRating = float.MinValue;
		var bestRatedShow = "";

		//var apiResponse = client.GetStringAsync($"{Base_URL}{currentPage}");

		try
		{
			while (currentPage <= totalPages)
			{
				var jsonResponse = await client.GetStringAsync(Base_URL + currentPage);
				var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);
				totalPages = apiResponse.TotalPages;

				foreach (var series in apiResponse.Data)
				{
					var rating = series.Rating;
					var name = series.Name;

					if (bestRatedShow == "" || rating > maxRating)
					{
						maxRating = rating;
						bestRatedShow = name;
						continue;
					}

					if (rating == maxRating && string.Compare(name, bestRatedShow, StringComparison.Ordinal) < 0)
					{
						bestRatedShow = name;
					}
				}

				currentPage++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		return bestRatedShow;
	}

}