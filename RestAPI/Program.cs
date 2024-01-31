using System.Net.Http.Headers;
var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://pokemon-api3.p.rapidapi.com/pokemon?name=salamence"),
	Headers =
	{
		{ "X-RapidAPI-Key", "b3733c7c03mshc70ab225b166faep18b027jsne23871af4ff5" },
		{ "X-RapidAPI-Host", "pokemon-api3.p.rapidapi.com" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}

Console.WriteLine("API executed successfully");