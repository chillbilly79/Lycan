using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lycan.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok("Healthy");
        }
    }
}