using System.Threading.Tasks;

namespace Lycan.Api.Service
{
    public interface IBroker
    {
        Task<IQuoteResponse> GetQuote(string tickerId);
    }

    public interface IQuoteResponse
    {
    }
}