using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApi.Services; 
using WebApi.Models;
using WebApi.DataProviders;

namespace WebApi.Tests.Services
{
    [TestClass]
    public class WeatherServiceTests
    {
        private WeatherService _weatherService;
        private Mock<IWeatherDataProvider> _mockWeatherDataProvider;

        [TestInitialize]
        public void Setup()
        {
            _mockWeatherDataProvider = new Mock<IWeatherDataProvider>();
            _weatherService = new WeatherService(_mockWeatherDataProvider.Object);
        }

        [TestMethod]
        public async Task GetWeatherForecasts_ReturnsForecast_WhenCalled()
        {
            // Arrange
            var expectedForecast = new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" }
            };
            _mockWeatherDataProvider
                .Setup(provider => provider.GetForecastsAsync())
                .ReturnsAsync(expectedForecast);

            // Act
            var result = await _weatherService.GetWeatherForecastsAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedForecast.Count, result.Count());
            Assert.AreEqual(expectedForecast.First().Summary, result.First().Summary);
        }

        [TestMethod]
        public async Task GetWeatherForecasts_ThrowsException_WhenDataProviderFails()
        {
            // Arrange
            _mockWeatherDataProvider
                .Setup(provider => provider.GetForecastsAsync())
                .ThrowsAsync(new Exception("Data provider error"));

            // Act & Assert
            await Assert.ThrowsExceptionAsync<Exception>(async () => 
                await _weatherService.GetWeatherForecastsAsync());
        }
    }
}