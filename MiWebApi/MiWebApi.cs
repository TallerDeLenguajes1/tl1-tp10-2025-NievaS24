// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Data
{
    public double open { get; set; }
    public double high { get; set; }
    public double low { get; set; }
    public double close { get; set; }
    public double volume { get; set; }
    public double adj_high { get; set; }
    public double adj_low { get; set; }
    public double adj_close { get; set; }
    public double adj_open { get; set; }
    public double adj_volume { get; set; }
    public double split_factor { get; set; }
    public double dividend { get; set; }
    public string name { get; set; }
    public string exchange_code { get; set; }
    public string asset_type { get; set; }
    public string price_currency { get; set; }
    public string symbol { get; set; }
    public string exchange { get; set; }
    public string date { get; set; }
}

public class Pagination
{
    public double limit { get; set; }
    public double offset { get; set; }
    public double count { get; set; }
    public double total { get; set; }
}

public class MarketStack
{
    public Pagination pagination { get; set; }
    public List<Data> data { get; set; }
}

