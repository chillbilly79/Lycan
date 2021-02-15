using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class Root1
    {
        [JsonPropertyName("MutualFund")] public MutualFund MutualFund { get; set; }

        [JsonPropertyName("Future")] public Future Future { get; set; }

        [JsonPropertyName("FutureOptions")] public FutureOptions FutureOptions { get; set; }

        [JsonPropertyName("Index")] public Index Index { get; set; }

        [JsonPropertyName("Option")] public Option Option { get; set; }

        [JsonPropertyName("Forex")] public Forex Forex { get; set; }

        [JsonPropertyName("ETF")] public ETF ETF { get; set; }

        [JsonPropertyName("Equity")] public Equity Equity { get; set; }
    }
}