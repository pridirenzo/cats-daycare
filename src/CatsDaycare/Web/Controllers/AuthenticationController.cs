using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService? _authenticationService;
        private readonly IConfiguration? _configuration;


        public AuthenticationController(IAuthenticationService service, IConfiguration configuration)
        {
            _authenticationService = service;
            _configuration = configuration;
        }

        [HttpPost("authenticate")] // post ya q se envian credenciales para el login
        public IActionResult Authenticate(AuthenticationRequest authenticationRequest)
        {
            var token = _authenticationService.Authenticate(authenticationRequest);
            return Ok(token);
            
        }


    }
}
