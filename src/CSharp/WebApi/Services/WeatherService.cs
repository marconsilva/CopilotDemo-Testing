using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.DataProviders;

namespace WebApi.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherDataProvider _dataProvider;

        /// <summary>
        /// Initializes a new instance of the WeatherService class with a dependency on IWeatherDataProvider
        /// </summary>
        /// <param name="dataProvider">Data provider for weather forecasts</param>
        public WeatherService(IWeatherDataProvider dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
        }

        /// <summary>
        /// Gets all available weather forecasts
        /// </summary>
        /// <returns>A collection of weather forecasts</returns>
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync()
        {
            return await _dataProvider.GetForecastsAsync();
        }

        /// <summary>
        /// Gets a specific weather forecast by date
        /// </summary>
        /// <param name="date">The date to get the forecast for</param>
        /// <returns>The weather forecast for the specified date or null if not found</returns>
        public async Task<WeatherForecast> GetWeatherForecastAsync(DateTime date)
        {
            return await _dataProvider.GetForecastByDateAsync(date);
        }

        /// <summary>
        /// Gets weather forecasts within a specified temperature range
        /// </summary>
        /// <param name="minTemp">Minimum temperature in Celsius</param>
        /// <param name="maxTemp">Maximum temperature in Celsius</param>
        /// <returns>Weather forecasts matching the temperature criteria</returns>
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsByTemperatureRangeAsync(int minTemp, int maxTemp)
        {
            return await _dataProvider.GetForecastsByTemperatureRangeAsync(minTemp, maxTemp);
        }

        /// <summary>
        /// Gets weather forecasts with precipitation above the specified threshold
        /// </summary>
        /// <param name="threshold">Minimum precipitation amount</param>
        /// <returns>Weather forecasts with precipitation above the threshold</returns>
        public async Task<IEnumerable<WeatherForecast>> GetRainyDayForecastsAsync(double threshold = 0)
        {
            return await _dataProvider.GetForecastsWithPrecipitationAboveAsync(threshold);
        }
    }
}