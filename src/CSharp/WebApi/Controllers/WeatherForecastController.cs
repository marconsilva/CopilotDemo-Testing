using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var forecasts = new List<WeatherForecast>();

            for (int i = 0; i < 5; i++)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                });
            }

            return forecasts;
        }
    }
}