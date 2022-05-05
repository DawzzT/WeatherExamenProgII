using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp.Infrastructure.Repository
{
    public class JsonRepository
    {
        
        public void JsonHistorialSerialize(HistoricalWeatherData data)
        {
            string weatherInfo = Newtonsoft.Json.JsonConvert.SerializeObject(data,Newtonsoft.Json.Formatting.Indented);
            File.AppendAllText("Weathers.json", weatherInfo);
        }
        public List<HistoricalWeatherData> JsonhistorialDeserialize()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<HistoricalWeatherData>>(File.ReadAllText("Weathers.json"));
        }
    }
}
