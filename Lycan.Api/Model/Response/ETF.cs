using System.Text.Json.Serialization;

namespace Lycan.Api.Model.Response
{
    public class ETF    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("bidPrice")]
        public double BidPrice { get; set; } 

        [JsonPropertyName("bidSize")]
        public int BidSize { get; set; } 

        [JsonPropertyName("bidId")]
        public string BidId { get; set; } 

        [JsonPropertyName("askPrice")]
        public double AskPrice { get; set; } 

        [JsonPropertyName("askSize")]
        public int AskSize { get; set; } 

        [JsonPropertyName("askId")]
        public string AskId { get; set; } 

        [JsonPropertyName("lastPrice")]
        public double LastPrice { get; set; } 

        [JsonPropertyName("lastSize")]
        public int LastSize { get; set; } 

        [JsonPropertyName("lastId")]
        public string LastId { get; set; } 

        [JsonPropertyName("openPrice")]
        public double OpenPrice { get; set; } 

        [JsonPropertyName("highPrice")]
        public double HighPrice { get; set; } 

        [JsonPropertyName("lowPrice")]
        public double LowPrice { get; set; } 

        [JsonPropertyName("closePrice")]
        public double ClosePrice { get; set; } 

        [JsonPropertyName("netChange")]
        public double NetChange { get; set; } 

        [JsonPropertyName("totalVolume")]
        public int TotalVolume { get; set; } 

        [JsonPropertyName("quoteTimeInLong")]
        public long QuoteTimeInLong { get; set; } 

        [JsonPropertyName("tradeTimeInLong")]
        public long TradeTimeInLong { get; set; } 

        [JsonPropertyName("mark")]
        public double Mark { get; set; } 

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; } 

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; } 

        [JsonPropertyName("marginable")]
        public bool Marginable { get; set; } 

        [JsonPropertyName("shortable")]
        public bool Shortable { get; set; } 

        [JsonPropertyName("volatility")]
        public double Volatility { get; set; } 

        [JsonPropertyName("digits")]
        public int Digits { get; set; } 

        [JsonPropertyName("52WkHigh")]
        public double _52WkHigh { get; set; } 

        [JsonPropertyName("52WkLow")]
        public double _52WkLow { get; set; } 

        [JsonPropertyName("peRatio")]
        public double PeRatio { get; set; } 

        [JsonPropertyName("divAmount")]
        public double DivAmount { get; set; } 

        [JsonPropertyName("divYield")]
        public double DivYield { get; set; } 

        [JsonPropertyName("divDate")]
        public string DivDate { get; set; } 

        [JsonPropertyName("securityStatus")]
        public string SecurityStatus { get; set; } 

        [JsonPropertyName("regularMarketLastPrice")]
        public double RegularMarketLastPrice { get; set; } 

        [JsonPropertyName("regularMarketLastSize")]
        public double RegularMarketLastSize { get; set; } 

        [JsonPropertyName("regularMarketNetChange")]
        public double RegularMarketNetChange { get; set; } 

        [JsonPropertyName("regularMarketTradeTimeInLong")]
        public long RegularMarketTradeTimeInLong { get; set; } 
    }
}