﻿using System;
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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            Close();
        }
    }
}
