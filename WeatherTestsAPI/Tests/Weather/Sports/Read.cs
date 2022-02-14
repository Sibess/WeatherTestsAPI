using WeatherTestsAPI.Services.Weather;
using NUnit.Framework;
using System.Linq;

namespace Weather.API.Tests.Tests.Weather.Sports
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnFootballSchedule()
        {
            var weatherService = new WeatherService();
            Assert.That(weatherService.GetSportsObjects().Football.Any());
        }
    }
}