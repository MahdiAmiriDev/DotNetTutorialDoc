using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Jwt.Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet("GetToken")]
        public IActionResult GetToken(string userName, string password)
        {
            var claims = new List<Claim>()
            {
                new Claim("userName", userName),
                new Claim("password", password)
            };

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mahdiAmiriNet"));
            var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer: "mahdiAmiriNet", audience: "mahdiAmiriNet",
                claims: claims, expires: DateTime.Now.AddDays(7), signingCredentials: credential);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(jwtToken);
        }

        [HttpGet("TestAuthorization")]
        [Authorize]
        public IActionResult TestAuthorization()
        {
            return Ok("jwtToken is correct");
        }
    }
}
