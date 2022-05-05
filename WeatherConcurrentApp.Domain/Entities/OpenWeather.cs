using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Entities
{
    public class OpenWeather
    {
        public Coord Coord { get; set; }
        public long dt { get; set; }
        
    }

    public class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

  
}