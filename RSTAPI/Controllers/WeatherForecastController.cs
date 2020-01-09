using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RSTRepsitory;

namespace RSTAPI.Controllers
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
        private readonly IAuthService authService;
        private readonly RSTContext context;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IAuthService authService,
            RSTContext context)
        {
            _logger = logger;
            this.authService = authService;
            this.context = context;
        }

        [HttpGet, Route("weather")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet, Route("check")]
        public IActionResult GetAllMember()
        {
            this.authService.Create(new Member
            {
                Account = DateTime.Now.ToString(),
                Password = DateTime.Now.ToString()
            });

            bool exist = this.authService.Exist(new Member
            {
                Account = "test",
                Password = "test"
            });

            return Ok(new
            {
                Exist = exist
            });
        }
    }
}
