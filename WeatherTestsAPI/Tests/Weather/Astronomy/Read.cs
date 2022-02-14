using WeatherTestsAPI.Services.Weather;
using NUnit.Framework;

namespace Weather.API.Tests.Tests.Weather.Astronomy
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnValidSunriseTime()
        {
            var weatherService = new WeatherService();
            Assert.That(weatherService.GetAstronomyObjects().Astronomy.Astro.Sunrise == "09:13 AM");
        }
    }
}