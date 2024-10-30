using FrontendAPI.Models;
using FrontendAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            // In a real application, you would validate the user credentials from a database
            if (loginModel.Username == "testuser" && loginModel.Password == "testpassword")
            {
                var token = _tokenService.GenerateToken(loginModel.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
