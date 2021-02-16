using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class Future
    {
        [JsonPropertyName("symbol")] public string Symbol { get; set; }

        [JsonPropertyName("bidPriceInDouble")] public double BidPriceInDouble { get; set; }

        [JsonPropertyName("askPriceInDouble")] public double AskPriceInDouble { get; set; }

        [JsonPropertyName("lastPriceInDouble")]
        public double LastPriceInDouble { get; set; }

        [JsonPropertyName("bidId")] public string BidId { get; set; }

        [JsonPropertyName("askId")] public string AskId { get; set; }

        [JsonPropertyName("highPriceInDouble")]
        public double HighPriceInDouble { get; set; }

        [JsonPropertyName("lowPriceInDouble")] public double LowPriceInDouble { get; set; }

        [JsonPropertyName("closePriceInDouble")]
        public double ClosePriceInDouble { get; set; }

        [JsonPropertyName("exchange")] public string Exchange { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("lastId")] public string LastId { get; set; }

        [JsonPropertyName("openPriceInDouble")]
        public double OpenPriceInDouble { get; set; }

        [JsonPropertyName("changeInDouble")] public double ChangeInDouble { get; set; }

        [JsonPropertyName("futurePercentChange")]
        public double FuturePercentChange { get; set; }

        [JsonPropertyName("exchangeName")] public string ExchangeName { get; set; }

        [JsonPropertyName("securityStatus")] public string SecurityStatus { get; set; }

        [JsonPropertyName("openInterest")] public double OpenInterest { get; set; }

        [JsonPropertyName("mark")] public double Mark { get; set; }

        [JsonPropertyName("tick")] public int Tick { get; set; }

        [JsonPropertyName("tickAmount")] public int TickAmount { get; set; }

        [JsonPropertyName("product")] public string Product { get; set; }

        [JsonPropertyName("futurePriceFormat")]
        public string FuturePriceFormat { get; set; }

        [JsonPropertyName("futureTradingHours")]
        public string FutureTradingHours { get; set; }

        [JsonPropertyName("futureIsTradable")] public bool FutureIsTradable { get; set; }

        [JsonPropertyName("futureMultiplier")] public int FutureMultiplier { get; set; }

        [JsonPropertyName("futureIsActive")] public bool FutureIsActive { get; set; }

        [JsonPropertyName("futureSettlementPrice")]
        public double FutureSettlementPrice { get; set; }

        [JsonPropertyName("futureActiveSymbol")]
        public string FutureActiveSymbol { get; set; }

        [JsonPropertyName("futureExpirationDate")]
        public string FutureExpirationDate { get; set; }
    }
}