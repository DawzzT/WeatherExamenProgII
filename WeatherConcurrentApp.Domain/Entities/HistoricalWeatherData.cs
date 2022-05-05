using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Entities
{
    public class HistoricalWeatherData
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public current current { get; set; }
        public List<hourly> hourly { get; set; }
    }

    public class current
    {
        public long dt { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
        public double temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Visibility { get; set; }
        public List<Weather> weather { get; set; }
    }
    public class hourly
    {
        public long dt { get; set; }
        public double temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public List<Weather> weather { get; set; }
    }
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
