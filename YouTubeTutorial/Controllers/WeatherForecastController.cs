using Microsoft.AspNetCore.Mvc;

namespace YouTubeTutorial.Controllers
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
        private IWebHostEnvironment _webHost;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _webHost = webHost;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("EnvCheck")]
        public IActionResult EnvCheck()
        {
            string ENV = string.Empty;

            if (_webHost.IsDevelopment())
            {
                ENV = "Development";
            }
            else if (_webHost.IsProduction())
            {
                ENV = "Production";
            }
            else if (_webHost.IsStaging())
            {
                ENV = "Staging";
            }

            return Ok(ENV);
        }
    }
}