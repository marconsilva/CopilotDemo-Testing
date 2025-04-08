using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.DataProviders
{
    /// <summary>
    /// Interface for retrieving weather forecast data
    /// </summary>
    public interface IWeatherDataProvider
    {
        /// <summary>
        /// Gets all available weather forecasts
        /// </summary>
        /// <returns>A collection of weather forecasts</returns>
        Task<IEnumerable<WeatherForecast>> GetForecastsAsync();
        
        /// <summary>
        /// Gets weather forecasts for a specific date
        /// </summary>
        /// <param name="date">The date to retrieve forecasts for</param>
        /// <returns>The weather forecast for the specified date</returns>
        Task<WeatherForecast> GetForecastByDateAsync(DateTime date);
        
        /// <summary>
        /// Gets weather forecasts filtered by temperature range
        /// </summary>
        /// <param name="minTemperature">Minimum temperature in Celsius</param>
        /// <param name="maxTemperature">Maximum temperature in Celsius</param>
        /// <returns>Weather forecasts matching the temperature criteria</returns>
        Task<IEnumerable<WeatherForecast>> GetForecastsByTemperatureRangeAsync(int minTemperature, int maxTemperature);
        
        /// <summary>
        /// Gets weather forecasts with precipitation above the specified threshold
        /// </summary>
        /// <param name="threshold">Minimum precipitation amount</param>
        /// <returns>Weather forecasts with precipitation above the threshold</returns>
        Task<IEnumerable<WeatherForecast>> GetForecastsWithPrecipitationAboveAsync(double threshold);
    }
}