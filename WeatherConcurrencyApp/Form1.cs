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
using WeatherConcurrentApp.Domain.Resources;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public LongDate ld;
        public HttphistoricalWeatherDataClient httphistoricalWeatherDataClient;
        public HistoricalWeatherData weather;
        public JsonRepository jsonRepos;
        public FrmMain()
        {
            ld = new LongDate();
            jsonRepos = new JsonRepository();
            httphistoricalWeatherDataClient = new HttphistoricalWeatherDataClient();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
           
        }
        
        public async Task Request()
        {
           weather = await httphistoricalWeatherDataClient.GetWeatherByCityNameAsync(textBox1.Text);
        }

     

        private void FrmMain_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;    
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            flpContent.Controls.Clear();
            groupBox1.Visible = true;
            try
            {
                Task.Run(Request).Wait();
                if (weather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + weather.current.weather[0].Icon + ".png";
                LblCiudad.Text = textBox1.Text.ToUpper();
                lblLat.Text = weather.lat.ToString();
                lblLon.Text = weather.lon.ToString();
                lblDt.Text = ld.convertLongToDate(weather.current.dt).ToString();
                lblDescription.Text = weather.current.weather[0].Description;
                lblHumidity.Text = weather.current.Humidity.ToString();
                lblPressure.Text = weather.current.Pressure.ToString();
                lblVisibility.Text = weather.current.Visibility.ToString();
                lblTemp.Text = ((int)weather.current.temp).ToString() + "°C";
                lblSunrise.Text = ld.convertLongToDate(weather.current.sunrise).ToShortTimeString();
                lblSunset.Text = ld.convertLongToDate(weather.current.sunset).ToShortTimeString();

                for (int i = 0; i < weather.hourly.Count; i++)
                {
                    WeatherPanel weatherPanel = new WeatherPanel();
                    weatherPanel.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + weather.hourly[i].weather[0].Icon + ".png";
                    weatherPanel.lblDescription.Text = weather.hourly[i].weather[0].Description;
                    weatherPanel.lblTemp.Text = ((int)weather.hourly[i].temp).ToString() + "°C";
                    weatherPanel.lblDt.Text = ld.convertLongToDate(weather.hourly[i].dt).ToString();
                    weatherPanel.lblPressure.Text = weather.hourly[i].Pressure.ToString();
                    weatherPanel.lblHumidity.Text = weather.hourly[i].Humidity.ToString();
                    flpContent.Controls.Add(weatherPanel);
                }
                //MessageBox.Show($"lon = { weather.hourly[0].temp}");
                //WeatherPanel weatherPanel = new WeatherPanel();
                //flpContent.Controls.Add(weatherPanel); 
                jsonRepos.JsonHistorialSerialize(weather);
            }
            catch (Exception)
            {

            }
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.ShowDialog();
        }
    }
}
