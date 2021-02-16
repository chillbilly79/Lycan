using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace Lycan.Api.Clients
{
    public interface ITdAmeritradeClient
    {
        [Get("/v1/marketdata/{id}/quotes?apikey=AERWWKQ13THVBH2ES7ZYUNRUHLZAL7PD")]
        public Task<HttpResponseMessage> GetQuoteAsync(string id);
    }
}