using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class Forex
    {
        [JsonPropertyName("symbol")] public string Symbol { get; set; }

        [JsonPropertyName("bidPriceInDouble")] public double BidPriceInDouble { get; set; }

        [JsonPropertyName("askPriceInDouble")] public double AskPriceInDouble { get; set; }

        [JsonPropertyName("lastPriceInDouble")]
        public double LastPriceInDouble { get; set; }

        [JsonPropertyName("highPriceInDouble")]
        public double HighPriceInDouble { get; set; }

        [JsonPropertyName("lowPriceInDouble")] public double LowPriceInDouble { get; set; }

        [JsonPropertyName("closePriceInDouble")]
        public double ClosePriceInDouble { get; set; }

        [JsonPropertyName("exchange")] public string Exchange { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("openPriceInDouble")]
        public double OpenPriceInDouble { get; set; }

        [JsonPropertyName("changeInDouble")] public double ChangeInDouble { get; set; }

        [JsonPropertyName("percentChange")] public double PercentChange { get; set; }

        [JsonPropertyName("exchangeName")] public string ExchangeName { get; set; }

        [JsonPropertyName("digits")] public int Digits { get; set; }

        [JsonPropertyName("securityStatus")] public string SecurityStatus { get; set; }

        [JsonPropertyName("tick")] public int Tick { get; set; }

        [JsonPropertyName("tickAmount")] public int TickAmount { get; set; }

        [JsonPropertyName("product")] public string Product { get; set; }

        [JsonPropertyName("tradingHours")] public string TradingHours { get; set; }

        [JsonPropertyName("isTradable")] public bool IsTradable { get; set; }

        [JsonPropertyName("marketMaker")] public string MarketMaker { get; set; }

        [JsonPropertyName("52WkHighInDouble")] public double _52WkHighInDouble { get; set; }

        [JsonPropertyName("52WkLowInDouble")] public double _52WkLowInDouble { get; set; }

        [JsonPropertyName("mark")] public double Mark { get; set; }
    }
}