using WeatherTestsAPI.Services.Weather;
using NUnit.Framework;

namespace Weather.API.Tests.Tests.Weather.Current
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnValidTemperature()
        {
            var weatherService = new WeatherService();
            Assert.That(weatherService.GetCurrentObjects().Current.Temp_c > -20);
        }
    }
}