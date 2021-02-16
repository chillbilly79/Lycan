using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class FutureOptions
    {
        [JsonPropertyName("symbol")] public string Symbol { get; set; }

        [JsonPropertyName("bidPriceInDouble")] public int BidPriceInDouble { get; set; }

        [JsonPropertyName("askPriceInDouble")] public int AskPriceInDouble { get; set; }

        [JsonPropertyName("lastPriceInDouble")]
        public int LastPriceInDouble { get; set; }

        [JsonPropertyName("highPriceInDouble")]
        public int HighPriceInDouble { get; set; }

        [JsonPropertyName("lowPriceInDouble")] public int LowPriceInDouble { get; set; }

        [JsonPropertyName("closePriceInDouble")]
        public int ClosePriceInDouble { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("openPriceInDouble")]
        public int OpenPriceInDouble { get; set; }

        [JsonPropertyName("netChangeInDouble")]
        public int NetChangeInDouble { get; set; }

        [JsonPropertyName("openInterest")] public int OpenInterest { get; set; }

        [JsonPropertyName("exchangeName")] public string ExchangeName { get; set; }

        [JsonPropertyName("securityStatus")] public string SecurityStatus { get; set; }

        [JsonPropertyName("volatility")] public int Volatility { get; set; }

        [JsonPropertyName("moneyIntrinsicValueInDouble")]
        public int MoneyIntrinsicValueInDouble { get; set; }

        [JsonPropertyName("multiplierInDouble")]
        public int MultiplierInDouble { get; set; }

        [JsonPropertyName("digits")] public int Digits { get; set; }

        [JsonPropertyName("strikePriceInDouble")]
        public int StrikePriceInDouble { get; set; }

        [JsonPropertyName("contractType")] public string ContractType { get; set; }

        [JsonPropertyName("underlying")] public string Underlying { get; set; }

        [JsonPropertyName("timeValueInDouble")]
        public int TimeValueInDouble { get; set; }

        [JsonPropertyName("deltaInDouble")] public int DeltaInDouble { get; set; }

        [JsonPropertyName("gammaInDouble")] public int GammaInDouble { get; set; }

        [JsonPropertyName("thetaInDouble")] public int ThetaInDouble { get; set; }

        [JsonPropertyName("vegaInDouble")] public int VegaInDouble { get; set; }

        [JsonPropertyName("rhoInDouble")] public int RhoInDouble { get; set; }

        [JsonPropertyName("mark")] public int Mark { get; set; }

        [JsonPropertyName("tick")] public int Tick { get; set; }

        [JsonPropertyName("tickAmount")] public int TickAmount { get; set; }

        [JsonPropertyName("futureIsTradable")] public bool FutureIsTradable { get; set; }

        [JsonPropertyName("futureTradingHours")]
        public string FutureTradingHours { get; set; }

        [JsonPropertyName("futurePercentChange")]
        public int FuturePercentChange { get; set; }

        [JsonPropertyName("futureIsActive")] public bool FutureIsActive { get; set; }

        [JsonPropertyName("futureExpirationDate")]
        public int FutureExpirationDate { get; set; }

        [JsonPropertyName("expirationType")] public string ExpirationType { get; set; }

        [JsonPropertyName("exerciseType")] public string ExerciseType { get; set; }

        [JsonPropertyName("inTheMoney")] public bool InTheMoney { get; set; }
    }
}