using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lycan.Extensions.Broker.Abstractions.Model;

namespace Lycan.Extensions.Broker.Abstractions
{
    public interface IBroker
    {
        public Task<Equity> GetEquityQuoteAsync(string symbol);
        public Task<Option> GetOptionQuoteAsync(string symbol);
        public Task<ETF> GetEtfQuoteAsync(string symbol);
        public Task<FutureOptions> GetFutureOptionsQuoteAsync(string symbol);
        public Task<Index> GetIndexQuoteAsync(string symbol);
        public Task<Forex> GetForexQuoteAsync(string symbol);
        public Task<MutualFund> GetMutualFundQuote(string symbol);


        public Task<Account> GetAccountAsync(long accountId);
        public Task<IEnumerable<Account>> GetAccountsAsync();

        public Task CancelOrderAsync(long accountId, long orderId);
        public Task<Order> GetOrderAsync(long accountId, long orderId);
        public Task<IEnumerable<Order>> GetOrdersAsync(GetOrderQuery query);

        public Task PlaceOrderAsync(PlaceOrderBody body);
        public Task ReplaceOrderAsync(long orderId, PlaceOrderBody body);

        public Task<OptionChain> GetOptionChainAsync(OptionChainRequest request);
    }
}