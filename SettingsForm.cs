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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            tbUsername.Text = Admin.user;
        }

        private void bAddCity_Click(object sender, EventArgs e)
        {
            bool cityAdded = Admin.AddCity(tbCityName.Text, tbCityId.Text);

            if (cityAdded) {
                MessageBox.Show("City " + tbCityName.Text + " successfully added!");

                tbCityName.Text = "";
                tbCityId.Text = "";
            } else MessageBox.Show("Could not add city! Please enter all the neccessary information.");
        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            int passwordChanged = Admin.ChangePassword(tbCurrentPass.Text, tbNewPass.Text, tbNewPassRep.Text);

            if (passwordChanged == 1) {
                MessageBox.Show("Password successfully changed!");

                tbCurrentPass.Text = "";
                tbNewPass.Text = "";
                tbNewPassRep.Text = "";
            } else if (passwordChanged == 0) MessageBox.Show("Could not change password! The new password was not repeated correctly.");
            else MessageBox.Show("Could not change password! Please enter your correct current password.");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            Close();
        }
    }
}
