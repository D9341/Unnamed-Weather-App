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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void bSignup_Click(object sender, EventArgs e)
        {
            if (tbUsernameSignup.Text != "" && tbPasswordSignup.Text != "") {
                Admin.SignUp(tbUsernameSignup.Text, tbPasswordSignup.Text);
                MessageBox.Show("Account successfully created! You can now log in!");
                LoginForm form = new LoginForm();
                form.Show();
                Close();
            } else {
                MessageBox.Show("Please enter account details!");
            }
        }

        private void bLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            Close();
        }

        private void cbVerify_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerify.Checked) bSignup.Enabled = true;
            else bSignup.Enabled = false;
        }
    }
}
