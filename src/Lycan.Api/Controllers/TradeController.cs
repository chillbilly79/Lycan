using System;
using System.Text.Json;
using System.Threading.Tasks;
using Lycan.Api.Clients;
using Lycan.Extensions.Broker.Abstractions.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lycan.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeController : ControllerBase
    {
        private readonly ITdAmeritradeClient _tdAmeritradeClient;

        public TradeController(ITdAmeritradeClient tdAmeritradeClient)
        {
            _tdAmeritradeClient = tdAmeritradeClient;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Future>> GetQuote(string id)
        {
            try
            {
                var response = await _tdAmeritradeClient.GetQuoteAsync(id);
                using var jdoc = await JsonDocument.ParseAsync(await response.Content.ReadAsStreamAsync());

                var root = jdoc.RootElement.GetProperty(id.ToUpper());
                var rootString = root.ToString();
                if (string.IsNullOrWhiteSpace(rootString)) throw new ArgumentNullException(nameof(rootString));

                var equity = JsonSerializer.Deserialize<Equity>(rootString);
                var etf = JsonSerializer.Deserialize<ETF>(rootString);
                var forex = JsonSerializer.Deserialize<Forex>(rootString);
                var future = JsonSerializer.Deserialize<Future>(rootString);

                return Ok(equity);
            }
            catch (Exception e)
            {
                var msg = e.Message;
            }

            return NotFound();
        }
    }

    public class Quote
    {
        public string Id { get; set; }
    }
}