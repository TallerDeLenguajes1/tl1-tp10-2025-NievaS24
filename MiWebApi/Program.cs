using System.Text.Json;

HttpClient client = new HttpClient();
string url = "https://api.marketstack.com/v2/eod?access_key=b3488c9a4291dc425d9efe9b197e7847&symbols=AAPL,AMZN,MELI,KO";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
MarketStack marketStacks = JsonSerializer.Deserialize<MarketStack>(responseBody);
List<Data> marketDatas = marketStacks.data;
Console.WriteLine($"*** Datos de la bolsa en los ultimos dias ***");
foreach (Data marketData in marketDatas)
{
    string stringFecha = marketData.date.Substring(0, 10); //Me queda solo la fecha 2025-06-27
    Console.WriteLine($"Nombre: {marketData.name} ({marketData.symbol})");
    Console.WriteLine($"\t Fecha: USD {stringFecha}");
    Console.WriteLine($"\t Apertura: USD {marketData.open:0.00}");
    Console.WriteLine($"\t Maximo: USD {marketData.high}");
    Console.WriteLine($"\t Minimo: USD {marketData.low}");
    Console.WriteLine($"\t Cierre: USD {marketData.close:0.00}");
    Console.WriteLine($"\t Volumen: {marketData.volume}\n\n");
}
string ruta = Directory.GetCurrentDirectory();
using (StreamWriter sw = new StreamWriter(ruta + @"\marketData.json"))
{
    string jsonString = JsonSerializer.Serialize(marketDatas);
    sw.WriteLine(jsonString);
}