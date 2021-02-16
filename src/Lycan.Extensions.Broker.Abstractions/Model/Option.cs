using System.Text.Json.Serialization;

namespace Lycan.Extensions.Broker.Abstractions.Model
{
    public class Option
    {
        [JsonPropertyName("symbol")] public string Symbol { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("bidPrice")] public int BidPrice { get; set; }

        [JsonPropertyName("bidSize")] public int BidSize { get; set; }

        [JsonPropertyName("askPrice")] public int AskPrice { get; set; }

        [JsonPropertyName("askSize")] public int AskSize { get; set; }

        [JsonPropertyName("lastPrice")] public int LastPrice { get; set; }

        [JsonPropertyName("lastSize")] public int LastSize { get; set; }

        [JsonPropertyName("openPrice")] public int OpenPrice { get; set; }

        [JsonPropertyName("highPrice")] public int HighPrice { get; set; }

        [JsonPropertyName("lowPrice")] public int LowPrice { get; set; }

        [JsonPropertyName("closePrice")] public int ClosePrice { get; set; }

        [JsonPropertyName("netChange")] public int NetChange { get; set; }

        [JsonPropertyName("totalVolume")] public int TotalVolume { get; set; }

        [JsonPropertyName("quoteTimeInLong")] public int QuoteTimeInLong { get; set; }

        [JsonPropertyName("tradeTimeInLong")] public int TradeTimeInLong { get; set; }

        [JsonPropertyName("mark")] public int Mark { get; set; }

        [JsonPropertyName("openInterest")] public int OpenInterest { get; set; }

        [JsonPropertyName("volatility")] public int Volatility { get; set; }

        [JsonPropertyName("moneyIntrinsicValue")]
        public int MoneyIntrinsicValue { get; set; }

        [JsonPropertyName("multiplier")] public int Multiplier { get; set; }

        [JsonPropertyName("strikePrice")] public int StrikePrice { get; set; }

        [JsonPropertyName("contractType")] public string ContractType { get; set; }

        [JsonPropertyName("underlying")] public string Underlying { get; set; }

        [JsonPropertyName("timeValue")] public int TimeValue { get; set; }

        [JsonPropertyName("deliverables")] public string Deliverables { get; set; }

        [JsonPropertyName("delta")] public int Delta { get; set; }

        [JsonPropertyName("gamma")] public int Gamma { get; set; }

        [JsonPropertyName("theta")] public int Theta { get; set; }

        [JsonPropertyName("vega")] public int Vega { get; set; }

        [JsonPropertyName("rho")] public int Rho { get; set; }

        [JsonPropertyName("securityStatus")] public string SecurityStatus { get; set; }

        [JsonPropertyName("theoreticalOptionValue")]
        public int TheoreticalOptionValue { get; set; }

        [JsonPropertyName("underlyingPrice")] public int UnderlyingPrice { get; set; }

        [JsonPropertyName("uvExpirationType")] public string UvExpirationType { get; set; }

        [JsonPropertyName("exchange")] public string Exchange { get; set; }

        [JsonPropertyName("exchangeName")] public string ExchangeName { get; set; }

        [JsonPropertyName("settlementType")] public string SettlementType { get; set; }
    }
}