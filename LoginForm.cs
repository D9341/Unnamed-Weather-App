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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (Admin.LogIn(tbUsernameLogin.Text, tbPasswordLogin.Text)) {
                Admin.user = tbUsernameLogin.Text;
                MessageBox.Show("Log in successful! Welcome, " + Admin.user + "!");
                MenuForm form = new MenuForm();
                form.Show();
                Close();
            } else {
                MessageBox.Show("Username or password doesn't match up (or you don't have an account)!");
                tbPasswordLogin.Text = "";
            }
        }

        private void bSignupForm_Click(object sender, EventArgs e)
        {
            SignupForm form = new SignupForm();
            form.Show();
            Close();
        }
    }
}
