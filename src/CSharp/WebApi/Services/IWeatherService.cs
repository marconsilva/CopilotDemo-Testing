using System;
using System.Collections.Generic;
using WebApi.Models;
using System.Threading.Tasks;

namespace WebApi.Services
{
    /// <summary>
    /// Provides weather forecast data and related operations
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Gets all weather forecasts
        /// </summary>
        /// <returns>A collection of weather forecasts</returns>
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();

        /// <summary>
        /// Gets a specific weather forecast by date
        /// </summary>
        /// <param name="date">The date to get the forecast for</param>
        /// <returns>The weather forecast for the specified date or null if not found</returns>
        Task<WeatherForecast> GetWeatherForecastAsync(DateTime date);
        
        /// <summary>
        /// Gets weather forecasts within a specified temperature range
        /// </summary>
        /// <param name="minTemp">Minimum temperature in Celsius</param>
        /// <param name="maxTemp">Maximum temperature in Celsius</param>
        /// <returns>Weather forecasts matching the temperature criteria</returns>
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastsByTemperatureRangeAsync(int minTemp, int maxTemp);
        
        /// <summary>
        /// Gets weather forecasts with precipitation above the specified threshold
        /// </summary>
        /// <param name="threshold">Minimum precipitation amount</param>
        /// <returns>Weather forecasts with precipitation above the threshold</returns>
        Task<IEnumerable<WeatherForecast>> GetRainyDayForecastsAsync(double threshold = 0);
    }
}