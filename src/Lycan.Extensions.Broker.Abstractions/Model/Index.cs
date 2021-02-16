// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class Index
    {
        [JsonPropertyName("symbol")] public string Symbol { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("lastPrice")] public int LastPrice { get; set; }

        [JsonPropertyName("openPrice")] public int OpenPrice { get; set; }

        [JsonPropertyName("highPrice")] public int HighPrice { get; set; }

        [JsonPropertyName("lowPrice")] public int LowPrice { get; set; }

        [JsonPropertyName("closePrice")] public int ClosePrice { get; set; }

        [JsonPropertyName("netChange")] public int NetChange { get; set; }

        [JsonPropertyName("totalVolume")] public int TotalVolume { get; set; }

        [JsonPropertyName("tradeTimeInLong")] public int TradeTimeInLong { get; set; }

        [JsonPropertyName("exchange")] public string Exchange { get; set; }

        [JsonPropertyName("exchangeName")] public string ExchangeName { get; set; }

        [JsonPropertyName("digits")] public int Digits { get; set; }

        [JsonPropertyName("52WkHigh")] public int _52WkHigh { get; set; }

        [JsonPropertyName("52WkLow")] public int _52WkLow { get; set; }

        [JsonPropertyName("securityStatus")] public string SecurityStatus { get; set; }
    }
}