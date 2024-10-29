using BackendAPI3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace BackendAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackendController : ControllerBase
    {
        // GET endpoint with artificial delay
        [HttpGet("data")]
        public async Task<IActionResult> GetData()
        {
            await Task.Delay(3000); // Simulate a 3-second delay
            return Ok("Data from API3 with delay");
        }

        // POST endpoint with artificial delay
        [HttpPost("data")]
        public async Task<IActionResult> PostData([FromBody] AppDocument data)
        {
            await Task.Delay(3000); // Simulate a 3-second delay
            return Ok("Data processed in API3");
        }
    }
}
