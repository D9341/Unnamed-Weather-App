﻿namespace Unnamed_Weather_App
{
    partial class WeatherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.cbCitySelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbCitySelect
            // 
            this.cbCitySelect.FormattingEnabled = true;
            this.cbCitySelect.Location = new System.Drawing.Point(200, 20);
            this.cbCitySelect.Name = "cbCitySelect";
            this.cbCitySelect.Size = new System.Drawing.Size(500, 33);
            this.cbCitySelect.TabIndex = 0;
            // 
            // WeatherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.cbCitySelect);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unnamed Weather App";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbCitySelect;
    }
}