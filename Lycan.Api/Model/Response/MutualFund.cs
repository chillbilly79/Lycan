using System.Text.Json.Serialization;

namespace Lycan.Api.Model.Response
{
    public class MutualFund    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } 

        [JsonPropertyName("closePrice")]
        public int ClosePrice { get; set; } 

        [JsonPropertyName("netChange")]
        public int NetChange { get; set; } 

        [JsonPropertyName("totalVolume")]
        public int TotalVolume { get; set; } 

        [JsonPropertyName("tradeTimeInLong")]
        public int TradeTimeInLong { get; set; } 

        [JsonPropertyName("exchange")]
        public string Exchange { get; set; } 

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; } 

        [JsonPropertyName("digits")]
        public int Digits { get; set; } 

        [JsonPropertyName("52WkHigh")]
        public int _52WkHigh { get; set; } 

        [JsonPropertyName("52WkLow")]
        public int _52WkLow { get; set; } 

        [JsonPropertyName("nAV")]
        public int NAV { get; set; } 

        [JsonPropertyName("peRatio")]
        public int PeRatio { get; set; } 

        [JsonPropertyName("divAmount")]
        public int DivAmount { get; set; } 

        [JsonPropertyName("divYield")]
        public int DivYield { get; set; } 

        [JsonPropertyName("divDate")]
        public string DivDate { get; set; } 

        [JsonPropertyName("securityStatus")]
        public string SecurityStatus { get; set; } 
    }
}