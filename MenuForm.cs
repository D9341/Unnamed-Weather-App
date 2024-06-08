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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void bWeatherForm_Click(object sender, EventArgs e)
        {
            WeatherForm form = new WeatherForm();
            form.Show();
            Close();
        }

        private void bSettingsForm_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
            Close();
        }

        private void bInfoForm_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.Show();
            Close();
        }

        private void bExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
