using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrencyApp.Infrastructure.Repository;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public HistoricalWeatherData weather;
        public JsonRepository jsonRepos;
        public FrmMain()
        {
            jsonRepos = new JsonRepository();
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();
                if(weather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                MessageBox.Show($"lon = { weather.hourly[0].temp}");
                //WeatherPanel weatherPanel = new WeatherPanel();
                //flpContent.Controls.Add(weatherPanel); 
                jsonRepos.JsonSerialize(weather);
            }
            catch (Exception)
            {
                
            }
           
        }
        DateTime convertLongToDate(long date)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            time = time.AddSeconds(date).ToLocalTime();
            return time;
        }
        public async Task Request()
        {
           weather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(textBox1.Text);
        }
    }
}
