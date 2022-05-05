using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherConcurrencyApp.Common;
using WeatherConcurrentApp.Domain.Entities;
using WeatherConcurrentApp.Domain.Interfaces;

namespace WeatherConcurrencyApp.Infrastructure.OpenWeatherClient
{
    public class HttpOpenWeatherClient : IHttpOpenWeatherClient
    {
        public async Task<HistoricalWeatherData> GetWeatherByCityNameAsync(string city)
        {
           
            string url = $"{AppSettings.ApiUrl}{city}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }
                   
                if(string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                OpenWeather cityInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
                url = $"{AppSettings.ApiUrl2}{cityInfo.Coord.Lat}&lon={cityInfo.Coord.Lon}&dt={cityInfo.dt}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<HistoricalWeatherData>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
