// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Data
{
    public double open { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double close { get; set; }
    public int volume { get; set; }
    public double adj_high { get; set; }
    public double adj_low { get; set; }
    public double adj_close { get; set; }
    public double adj_open { get; set; }
    public int adj_volume { get; set; }
    public int split_factor { get; set; }
    public double dividend { get; set; }
    public string name { get; set; }
    public string exchange_code { get; set; }
    public string asset_type { get; set; }
    public string price_currency { get; set; }
    public string symbol { get; set; }
    public string exchange { get; set; }
    public DateTime date { get; set; }
}

public class Pagination
{
    public int limit { get; set; }
    public int offset { get; set; }
    public int count { get; set; }
    public int total { get; set; }
}

public class MarketStack
{
    public Pagination pagination { get; set; }
    public List<Data> data { get; set; }
}

