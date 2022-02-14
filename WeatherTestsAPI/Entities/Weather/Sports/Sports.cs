using System.Collections.Generic;

namespace WeatherTestsAPI.Entities.Weather.Sports
{
    public class RootSports
    {
        public List<Football> Football { get; set; }
        public List<Cricket> Cricket { get; set; }
        public List<object> Golf { get; set; }
    }

    public class Football
    {
        public string Stadium { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Tournament { get; set; }
        public string Start { get; set; }
        public string Match { get; set; }
    }

    public class Cricket
    {
        public string Stadium { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Tournament { get; set; }
        public string Start { get; set; }
        public string Match { get; set; }
    }
}