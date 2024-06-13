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

            tbTemperature.Text = data.list[0].main.temp + " K";
            tbFeelsLike.Text = data.list[0].main.feels_like + " K";
            tbMinMaxTemp.Text = data.list[0].main.temp_min + " / " + data.list[0].main.temp_max + " K";
        }
    }
}
