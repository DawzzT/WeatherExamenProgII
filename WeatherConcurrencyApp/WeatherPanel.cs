using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {
        public WeatherPanel()
        {
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            DetailsWeather dw1 = new DetailsWeather();
            dw1.lblDetailValue.Text = "lon";
            flpContent.Controls.Add(dw1);

            DetailsWeather dw2 = new DetailsWeather();
            dw2.lblDetailValue.Text = "lat";
            flpContent.Controls.Add(dw2);

            DetailsWeather dw3 = new DetailsWeather();
            dw3.lblDetailValue.Text = "temp";
            flpContent.Controls.Add(dw3);

            DetailsWeather dw4 = new DetailsWeather();
            dw4.lblDetailValue.Text = "feels_like";
            flpContent.Controls.Add(dw4);

            DetailsWeather dw5 = new DetailsWeather();
            dw5.lblDetailValue.Text = "temp_min";
            flpContent.Controls.Add(dw5);

            DetailsWeather dw6 = new DetailsWeather();
            dw6.lblDetailValue.Text = "temp_max";
            flpContent.Controls.Add(dw6);

            DetailsWeather dw7 = new DetailsWeather();
            dw7.lblDetailValue.Text = "pressure";
            flpContent.Controls.Add(dw7);

            DetailsWeather dw8 = new DetailsWeather();
            dw8.lblDetailValue.Text = "humidity";
            flpContent.Controls.Add(dw8);

            DetailsWeather dw9 = new DetailsWeather();
            dw9.lblDetailValue.Text = "visibility";
            flpContent.Controls.Add(dw9);

            DetailsWeather dw10 = new DetailsWeather();
            dw10.lblDetailValue.Text = "speed";
            flpContent.Controls.Add(dw10);

            DetailsWeather dw11 = new DetailsWeather();
            dw11.lblDetailValue.Text = "sunrise";
            flpContent.Controls.Add(dw11);

            DetailsWeather dw12 = new DetailsWeather();
            dw12.lblDetailValue.Text = "sunset";
            flpContent.Controls.Add(dw12);

            DetailsWeather dw13 = new DetailsWeather();
            dw13.lblDetailValue.Text = "timezone";
            flpContent.Controls.Add(dw13);
        }
    }
}
