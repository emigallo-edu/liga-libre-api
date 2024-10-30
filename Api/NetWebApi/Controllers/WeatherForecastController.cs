using Microsoft.AspNetCore.Mvc;

namespace NetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public WeatherForecastController()
        {
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return this.GetForecast();
        }

        [HttpGet("name/{name}")]
        public IEnumerable<WeatherForecast> GetWeatherForecastWithQueryPath([FromRoute] string name)
        {
            throw new ArgumentException();
            return this.GetForecast().Where(x => x.Summary == name);
        }

        [HttpGet("temp/{temp}")]
        public IEnumerable<WeatherForecast> GetWeatherForecastWithQueryPath([FromRoute] int temp)
        {
            return this.GetForecast().Where(x => x.TemperatureC == temp);
        }

        [HttpGet("query")]
        public IEnumerable<WeatherForecast> GetWeatherForecastWithQueryParams([FromQuery] string name)
        {
            return this.GetForecast().Where(x => x.Summary == name);
        }

        [HttpPost]
        public IActionResult CreateWeatherForecast(WeatherForecast item)
        {
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateWeatherForecast(WeatherForecast item)
        {
            return Ok(item);
        }

        private List<WeatherForecast> GetForecast()
        {
            List<WeatherForecast> rett = new List<WeatherForecast>();
            string[] summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            foreach (string summary in summaries)
            {
                rett.Add(new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = Random.Shared.Next(20, 25),
                    Summary = summary
                });
            }
            return rett;
        }
    }
}