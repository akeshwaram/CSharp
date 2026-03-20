namespace InputOutput;

internal class HttpClientExample
{
	static readonly HttpClient client = new HttpClient();

	public static async Task GetHtml(string url)
	{
		var response = await client.GetAsync(url);
		response.EnsureSuccessStatusCode();
		string body = await response.Content.ReadAsStringAsync();

		//client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token)
		


	}
}
