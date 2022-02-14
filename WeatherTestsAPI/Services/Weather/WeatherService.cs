using WeatherTestsAPI.Entities.Weather.Astronomy;
using WeatherTestsAPI.Entities.Weather.Current;
using WeatherTestsAPI.Entities.Weather.Forecast;
using WeatherTestsAPI.Entities.Weather.Search;
using WeatherTestsAPI.Entities.Weather.Sports;
using WeatherTestsAPI.Entities.Weather.TimeZone;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace WeatherTestsAPI.Services.Weather
{
    public class WeatherService : BaseService

    {
        private static readonly string BaseUrl = "http://api.weatherapi.com";

        public WeatherService() : base(BaseUrl)
        {
        }

        public RootCurrent GetCurrentObjects()
        {
            var currentObjects = JsonConvert.DeserializeObject<RootCurrent>(GetResponse("/v1/current.json?key=ee80bc25d7944df9a2d174121222501&q=minsk&aqi=no", Method.GET).Content);
            return currentObjects;
        }

        public RootForecast GetForecastObjects()
        {
            var forecastObjects = JsonConvert.DeserializeObject<RootForecast>(GetResponse("/v1/forecast.json?key=ee80bc25d7944df9a2d174121222501&q=minsk&days=1&aqi=no&alerts=no", Method.GET).Content);
            return forecastObjects;
        }

        public List<RootSearch> GetSearchObjects()
        {
            var searchObjects = JsonConvert.DeserializeObject<List<RootSearch>>(GetResponse("/v1/search.json?key=ee80bc25d7944df9a2d174121222501&q=mins&days=1&aqi=no&alerts=no", Method.GET).Content);
            return searchObjects;
        }

        public RootSports GetSportsObjects()
        {
            var sportsObjects = JsonConvert.DeserializeObject<RootSports>(GetResponse("/v1/sports.json?key=ee80bc25d7944df9a2d174121222501&q=minsk", Method.GET).Content);
            return sportsObjects;
        }

        public RootAstronomy GetAstronomyObjects()
        {
            var astronomyObjects = JsonConvert.DeserializeObject<RootAstronomy>(GetResponse("/v1/astronomy.json?key=ee80bc25d7944df9a2d174121222501&q=minsk&dt=2022-01-21", Method.GET).Content);
            return astronomyObjects;
        }

        public RootTimeZone GetTimeZoneObjects()
        {
            var TimeZoneObjects = JsonConvert.DeserializeObject<RootTimeZone>(GetResponse("/v1/timezone.json?key=ee80bc25d7944df9a2d174121222501&q=minsk", Method.GET).Content);
            return TimeZoneObjects;
        }
    }
}