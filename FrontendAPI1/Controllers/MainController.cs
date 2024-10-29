using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FrontEndAPI.Services;
using FrontendAPI.Models; 

namespace FrontEndAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MainController : ControllerBase
{
    private readonly IAPIService _apiService;

    public MainController(IAPIService apiService)
    {
        _apiService = apiService;
    }

    [HttpGet("data")]
    // [Authorize]
    public async Task<IActionResult> GetData()
    {
        var result = await _apiService.FetchDataAsync();
        return Ok(result);
    }

    [HttpPost("data")]
    // [Authorize]
    public async Task<IActionResult> PostData([FromBody] AppDocument data)
    {
        var result = await _apiService.SendDataAsync(data);
        return Ok(result);
    }
}
