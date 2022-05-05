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
    public partial class frmHistorial : Form
    {
        public LongDate ld;
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public JsonRepository jsonRepos;
        public OpenWeather opWeather;
        public List<HistoricalWeatherData> data;
        public frmHistorial()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            ld = new LongDate();
            jsonRepos = new JsonRepository();
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            flpContent.Controls.Clear();
            textBox2.Visible = false;
            try
            {
                Task.Run(Request).Wait();
                if (opWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                data = jsonRepos.JsonhistorialDeserialize();
                if (data == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                MessageBox.Show($"{data[0].current.sunrise}");
                List<HistoricalWeatherData> HistorialCity = new List<HistoricalWeatherData>();

                for(int i =0; i<data.Count;i++)
                {
                    if(opWeather.Coord.Lat == data[i].lat && opWeather.Coord.Lon == data[i].lon)
                    {
                        HistorialCity.Add(data[i]);
                    }
                }
                if (HistorialCity == null)
                {
                    textBox2.Visible = true;
                }
                for(int i =0; i< HistorialCity.Count; i++)
                {
                    WeatherPanel weatherPanel = new WeatherPanel();
                    weatherPanel.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + HistorialCity[i].current.weather[0].Icon + ".png";
                    weatherPanel.lblDescription.Text = HistorialCity[i].current.weather[0].Description;
                    weatherPanel.lblDt.Text = ld.convertLongToDate(HistorialCity[i].current.dt).ToString();
                    weatherPanel.lblHumidity.Text = HistorialCity[i].current.Humidity.ToString();
                    weatherPanel.lblPressure.Text = HistorialCity[i].current.Pressure.ToString();
                    weatherPanel.lblTemp.Text = ((int)HistorialCity[i].current.temp).ToString()+ "°C";
                    flpContent.Controls.Add(weatherPanel);
                    for(int j=0; j < HistorialCity[i].hourly.Count; i++)
                    {
                        WeatherPanel weatherPanel2 = new WeatherPanel();
                        weatherPanel2.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + HistorialCity[i].hourly[j].weather[0].Icon + ".png";
                        weatherPanel2.lblDescription.Text = HistorialCity[i].hourly[j].weather[0].Description;
                        weatherPanel2.lblDt.Text = ld.convertLongToDate(HistorialCity[i].hourly[j].dt).ToString();
                        weatherPanel2.lblHumidity.Text = HistorialCity[i].hourly[j].Humidity.ToString();
                        weatherPanel2.lblPressure.Text = HistorialCity[i].hourly[j].Pressure.ToString();
                        weatherPanel2.lblTemp.Text = ((int)HistorialCity[i].hourly[j].temp).ToString() + "°C";
                        flpContent.Controls.Add(weatherPanel2);
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        public async Task Request()
        {
            opWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCiudad_Click(object sender, EventArgs e)
        {

        }
    }
}
