namespace WeatherTestsAPI.Entities.Weather.Astronomy
{
    public class RootAstronomy
    {
        public Location Location { get; set; }
        public Astronomy Astronomy { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Tz_id { get; set; }
        public int Localtime_epoch { get; set; }
        public string Localtime { get; set; }
    }

    public class Astro
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set; }
        public string Moon_phase { get; set; }
        public string Moon_illumination { get; set; }
    }

    public class Astronomy
    {
        public Astro Astro { get; set; }
    }
}