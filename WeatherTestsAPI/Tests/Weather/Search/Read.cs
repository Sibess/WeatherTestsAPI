using WeatherTestsAPI.Services.Weather;
using NUnit.Framework;
using System.Linq;

namespace Weather.API.Tests.Tests.Weather.Search
{
    [TestFixture, Category("Smoke")]
    public class Read
    {
        [Test]
        public void ShouldReturnValidLocation()
        {
            var weatherService = new WeatherService();
            foreach (var item in weatherService.GetSearchObjects().Select(c => c.Country))
            {
                Assert.That(item == "Belarus");
            }
            foreach (var item in weatherService.GetSearchObjects().Select(c => c.Region))
            {
                Assert.That(item == "Minsk");
            }
        }
    }
}