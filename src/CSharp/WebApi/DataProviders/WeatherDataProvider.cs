using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;
using System.Threading.Tasks;

namespace WebApi.DataProviders
{
    /// <summary>
    /// Implementation of the weather data provider that uses an in-memory data source
    /// </summary>
    public class WeatherDataProvider : IWeatherDataProvider
    {
        private readonly List<WeatherForecast> _forecastData;

        public WeatherDataProvider()
        {
            // Initialize with some sample data
            _forecastData = new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 20, Summary = "Warm", Precipitation = 0 },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 22, Summary = "Sunny", Precipitation = 0 },
                new WeatherForecast { Date = DateTime.Now.AddDays(2), TemperatureC = 18, Summary = "Cloudy", Precipitation = 1 },
                new WeatherForecast { Date = DateTime.Now.AddDays(3), TemperatureC = 15, Summary = "Rainy", Precipitation = 5 },
                new WeatherForecast { Date = DateTime.Now.AddDays(4), TemperatureC = 12, Summary = "Stormy", Precipitation = 10 }
            };
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastsAsync()
        {
            return await Task.FromResult(_forecastData);
        }

        public async Task<WeatherForecast> GetForecastByDateAsync(DateTime date)
        {
            return await Task.FromResult(_forecastData.FirstOrDefault(f => f.Date.Date == date.Date));
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastsByTemperatureRangeAsync(int minTemperature, int maxTemperature)
        {
            return await Task.FromResult(_forecastData.Where(f => 
                f.TemperatureC >= minTemperature && f.TemperatureC <= maxTemperature).ToList());
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastsWithPrecipitationAboveAsync(double threshold)
        {
            return await Task.FromResult(_forecastData.Where(f => f.Precipitation > threshold).ToList());
        }
    }
}