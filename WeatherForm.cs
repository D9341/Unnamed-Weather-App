using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unnamed_Weather_App
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
            cbCitySelect.DataSource = Admin.FetchCities();
        }

        private void cbCitySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cityData = cbCitySelect.Text.Split('|');
            Root data = Admin.FetchWeatherData(int.Parse(cityData[1]), Admin.apiKey);

            // Temperature data
            tbTemperature.Text = (Math.Round(data.list[0].main.temp - 273.15f, 2)).ToString() + " C";
            tbFeelsLike.Text = (Math.Round(data.list[0].main.feels_like - 273.15f, 2)).ToString() + " C";
            tbMinMaxTemp.Text = (Math.Round(data.list[0].main.temp_min - 273.15f, 2)).ToString() + " / " + (Math.Round(data.list[0].main.temp_max - 273.15f, 2)).ToString() + " C";

            // Pressure data
            tbPressure.Text = data.list[0].main.pressure.ToString() + " hPa";
            tbSeaLevel.Text = data.list[0].main.sea_level.ToString() + " hPa";
            tbGroundLevel.Text = data.list[0].main.grnd_level.ToString() + " hPa";

            // Misc data
            tbHumidity.Text = data.list[0].main.humidity.ToString() + "%";
            tbCloudCover.Text = data.list[0].clouds.all.ToString() + "%";
            tbVisibility.Text = data.list[0].visibility.ToString() + " m";

            // Wind data
            tbWindSpeed.Text = (Math.Round(data.list[0].wind.speed, 2)).ToString() + " m/s";
            tbWindGust.Text = (Math.Round(data.list[0].wind.gust, 2)).ToString() + " m/s";
            tbWindDirection.Text = data.list[0].wind.deg.ToString();

            // Weather forecast
            if (data.list[0].weather[0].id >= 200 && data.list[0].weather[0].id < 300) // Thunderstorm weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Thunderstorm.jpg");
            }
            else if (data.list[0].weather[0].id >= 300 && data.list[0].weather[0].id < 400) // Drizzle weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Light rain.jpg");
            }
            else if (data.list[0].weather[0].id >= 500 && data.list[0].weather[0].id < 600) // Rain weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Rain.jpg");
            }
            else if (data.list[0].weather[0].id >= 600 && data.list[0].weather[0].id < 700) // Snow weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Snow.jpg");
            }
            else if (data.list[0].weather[0].id >= 700 && data.list[0].weather[0].id < 800) // Athmospehere weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Athmosphere.jpg");
            }
            else if (data.list[0].weather[0].id == 800) // Clear weather
            {
                pbWeather.Image = Image.FromFile("assets/weather/Sun.jpg");
            }
            else if (data.list[0].weather[0].id >= 800) // Clouds weather group
            {
                pbWeather.Image = Image.FromFile("assets/weather/Cloud.jpg");
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            Close();
        }
    }
}
