using System.Text.Json;

HttpClient client = new HttpClient();
string url = "https://api.marketstack.com/v2/eod?access_key=b3488c9a4291dc425d9efe9b197e7847&symbols=AAPL,AMZN,MELI,KO";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
MarketStack marketStacks = JsonSerializer.Deserialize<MarketStack>(responseBody);
List<Data> marketDatas = marketStacks.data;
