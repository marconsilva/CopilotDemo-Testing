using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Controllers;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Tests.Controllers
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _controller;
        private Mock<IWeatherService> _mockService;

        [TestInitialize]
        public void Setup()
        {
            _mockService = new Mock<IWeatherService>();
            _controller = new WeatherForecastController(_mockService.Object);
        }

        [TestMethod]
        public void GetWeatherForecast_ReturnsOkResult_WithWeatherForecasts()
        {
            // Arrange
            var weatherForecasts = new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Warm" },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 30, Summary = "Hot" }
            };
            _mockService
                .Setup(service => service.GetWeatherForecastsAsync())
                .ReturnsAsync(weatherForecasts);

            // Act
            var result = _controller.Get();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var forecasts = okResult.Value as IEnumerable<WeatherForecast>;
            Assert.AreEqual(2, forecasts.Count());
        }

        [TestMethod]
        public void GetWeatherForecast_ReturnsNotFound_WhenNoForecasts()
        {
            // Arrange
            _mockService
                .Setup(service => service.GetWeatherForecastsAsync())
                .ReturnsAsync(new List<WeatherForecast>());

            // Act
            var result = _controller.Get();

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}