using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrentApp.Domain.Interfaces
{
    public interface IHttpHistorialWeatherDataClient
    {
       
        Task<HistoricalWeatherData> GetWeatherByCityNameAsync(string city);
    }
}
