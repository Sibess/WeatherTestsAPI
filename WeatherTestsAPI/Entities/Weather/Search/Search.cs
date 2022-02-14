namespace WeatherTestsAPI.Entities.Weather.Search
{
    public class Search
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Url { get; set; }
    }
}