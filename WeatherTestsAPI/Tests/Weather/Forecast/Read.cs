using WeatherTestsAPI.Services.Weather;
using NUnit.Framework;
using System.Linq;

namespace Weather.API.Tests.Tests.Weather.Forecast
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnValidTemperature()
        {
            var weatherService = new WeatherService();
            Assert.That(Queryable.Average(weatherService.GetForecastObjects().Forecast.Forecastday[0].Hour.Select(c => c.Temp_c).ToList().AsQueryable()) > -20);
        }
    }
}