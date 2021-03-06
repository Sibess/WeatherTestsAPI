using System.Collections.Generic;

namespace WeatherTestsAPI.Entities.Weather.Forecast
{
    public class RootForecast
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
        public Forecast Forecast { get; set; }
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

    public class Condition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }

    public class Current
    {
        public int Last_updated_epoch { get; set; }
        public string Last_updated { get; set; }
        public double Temp_c { get; set; }
        public double Temp_f { get; set; }
        public int Is_day { get; set; }
        public Condition Condition { get; set; }
        public double Wind_mph { get; set; }
        public double Wind_kph { get; set; }
        public int Wind_degree { get; set; }
        public string Wind_dir { get; set; }
        public double Pressure_mb { get; set; }
        public double Pressure_in { get; set; }
        public double Precip_mm { get; set; }
        public double Precip_in { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double Feelslike_c { get; set; }
        public double Feelslike_f { get; set; }
        public double Vis_km { get; set; }
        public double Vis_miles { get; set; }
        public double Uv { get; set; }
        public double Gust_mph { get; set; }
        public double Gust_kph { get; set; }
    }

    public class Day
    {
        public double Maxtemp_c { get; set; }
        public double Maxtemp_f { get; set; }
        public double Mintemp_c { get; set; }
        public double Mintemp_f { get; set; }
        public double Avgtemp_c { get; set; }
        public double Avgtemp_f { get; set; }
        public double Maxwind_mph { get; set; }
        public double Maxwind_kph { get; set; }
        public double Totalprecip_mm { get; set; }
        public double Totalprecip_in { get; set; }
        public double Avgvis_km { get; set; }
        public double Avgvis_miles { get; set; }
        public double Avghumidity { get; set; }
        public int Daily_will_it_rain { get; set; }
        public int Daily_chance_of_rain { get; set; }
        public int Daily_will_it_snow { get; set; }
        public int Daily_chance_of_snow { get; set; }
        public Condition Condition { get; set; }
        public double Uv { get; set; }
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

    public class Hour
    {
        public int Time_epoch { get; set; }
        public string Time { get; set; }
        public double Temp_c { get; set; }
        public double Temp_f { get; set; }
        public int Is_day { get; set; }
        public Condition Condition { get; set; }
        public double Wind_mph { get; set; }
        public double Wind_kph { get; set; }
        public int Wind_degree { get; set; }
        public string Wind_dir { get; set; }
        public double Pressure_mb { get; set; }
        public double Pressure_in { get; set; }
        public double Precip_mm { get; set; }
        public double Precip_in { get; set; }
        public int Humidity { get; set; }
        public int Cloud { get; set; }
        public double Feelslike_c { get; set; }
        public double Feelslike_f { get; set; }
        public double Windchill_c { get; set; }
        public double Windchill_f { get; set; }
        public double Heatindex_c { get; set; }
        public double Heatindex_f { get; set; }
        public double Dewpoint_c { get; set; }
        public double Dewpoint_f { get; set; }
        public int Will_it_rain { get; set; }
        public int Chance_of_rain { get; set; }
        public int Will_it_snow { get; set; }
        public int Chance_of_snow { get; set; }
        public double Vis_km { get; set; }
        public double Vis_miles { get; set; }
        public double Gust_mph { get; set; }
        public double Gust_kph { get; set; }
        public double Uv { get; set; }
    }

    public class Forecastday
    {
        public string Date { get; set; }
        public int Date_epoch { get; set; }
        public Day Day { get; set; }
        public Astro Astro { get; set; }
        public List<Hour> Hour { get; set; }
    }

    public class Forecast
    {
        public List<Forecastday> Forecastday { get; set; }
    }
}