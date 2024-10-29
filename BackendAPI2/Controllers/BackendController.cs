using BackendAPI2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackendController : ControllerBase
    {
        // GET endpoint with artificial delay
        [HttpGet("data")]
        public async Task<IActionResult> GetData()
        {
            await Task.Delay(5000); // Simulate a long-running process with a 5-second delay
            return Ok("Data from API2 with delay");
        }

        // POST endpoint with artificial delay
        [HttpPost("data")]
        public async Task<IActionResult> PostData([FromBody] AppDocument data)
        {
            await Task.Delay(5000); // Simulate a long-running process with a 5-second delay
            return Ok("Data processed in API2");
        }
    }
}
