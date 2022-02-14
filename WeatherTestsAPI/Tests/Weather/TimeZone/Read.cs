using NUnit.Framework;
using WeatherTestsAPI.Services.Weather;

namespace Weather.API.Tests.Tests.Weather.TimeZone
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnValidTimeZone()
        {
            var weatherService = new WeatherService();
            Assert.That(weatherService.GetTimeZoneObjects().Location.Tz_id == "Europe/Minsk");
        }
    }
}