namespace Unnamed_Weather_App
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
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.pbTemperature = new System.Windows.Forms.PictureBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblMinMaxTemp = new System.Windows.Forms.Label();
            this.pbFeelsLike = new System.Windows.Forms.PictureBox();
            this.pbMinMaxTemp = new System.Windows.Forms.PictureBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbFeelsLike = new System.Windows.Forms.TextBox();
            this.tbMinMaxTemp = new System.Windows.Forms.TextBox();
            this.tbGroundLevel = new System.Windows.Forms.TextBox();
            this.tbSeaLevel = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.pbGroundLevel = new System.Windows.Forms.PictureBox();
            this.pbSeaLevel = new System.Windows.Forms.PictureBox();
            this.lblGroundLevel = new System.Windows.Forms.Label();
            this.lblSeaLevel = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.pbPressure = new System.Windows.Forms.PictureBox();
            this.tbVisibility = new System.Windows.Forms.TextBox();
            this.tbCloudCover = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.pbVisibility = new System.Windows.Forms.PictureBox();
            this.pbCloudCover = new System.Windows.Forms.PictureBox();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.lblCloudCover = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.pbHumidity = new System.Windows.Forms.PictureBox();
            this.tbWindDirection = new System.Windows.Forms.TextBox();
            this.tbWindGust = new System.Windows.Forms.TextBox();
            this.tbWindSpeed = new System.Windows.Forms.TextBox();
            this.pbWindDirection = new System.Windows.Forms.PictureBox();
            this.pbWindGust = new System.Windows.Forms.PictureBox();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblWindGust = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.pbWindSpeed = new System.Windows.Forms.PictureBox();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeelsLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroundLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeaLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindGust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCitySelect
            // 
            this.cbCitySelect.FormattingEnabled = true;
            this.cbCitySelect.Location = new System.Drawing.Point(200, 20);
            this.cbCitySelect.Name = "cbCitySelect";
            this.cbCitySelect.Size = new System.Drawing.Size(500, 33);
            this.cbCitySelect.TabIndex = 0;
            this.cbCitySelect.SelectedIndexChanged += new System.EventHandler(this.cbCitySelect_SelectedIndexChanged);
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(360, 80);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(150, 150);
            this.pbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather.TabIndex = 1;
            this.pbWeather.TabStop = false;
            // 
            // pbTemperature
            // 
            this.pbTemperature.BackColor = System.Drawing.Color.Transparent;
            this.pbTemperature.Image = ((System.Drawing.Image)(resources.GetObject("pbTemperature.Image")));
            this.pbTemperature.Location = new System.Drawing.Point(21, 110);
            this.pbTemperature.Name = "pbTemperature";
            this.pbTemperature.Size = new System.Drawing.Size(32, 32);
            this.pbTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTemperature.TabIndex = 2;
            this.pbTemperature.TabStop = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Location = new System.Drawing.Point(53, 110);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(185, 32);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "Temperature:";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.Location = new System.Drawing.Point(53, 185);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(185, 32);
            this.lblFeelsLike.TabIndex = 4;
            this.lblFeelsLike.Text = "Feels like:";
            this.lblFeelsLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMinMaxTemp
            // 
            this.lblMinMaxTemp.Location = new System.Drawing.Point(53, 260);
            this.lblMinMaxTemp.Name = "lblMinMaxTemp";
            this.lblMinMaxTemp.Size = new System.Drawing.Size(185, 32);
            this.lblMinMaxTemp.TabIndex = 5;
            this.lblMinMaxTemp.Text = "Min / max temp:";
            this.lblMinMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFeelsLike
            // 
            this.pbFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.pbFeelsLike.Image = ((System.Drawing.Image)(resources.GetObject("pbFeelsLike.Image")));
            this.pbFeelsLike.Location = new System.Drawing.Point(21, 185);
            this.pbFeelsLike.Name = "pbFeelsLike";
            this.pbFeelsLike.Size = new System.Drawing.Size(32, 32);
            this.pbFeelsLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFeelsLike.TabIndex = 6;
            this.pbFeelsLike.TabStop = false;
            // 
            // pbMinMaxTemp
            // 
            this.pbMinMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.pbMinMaxTemp.Image = ((System.Drawing.Image)(resources.GetObject("pbMinMaxTemp.Image")));
            this.pbMinMaxTemp.Location = new System.Drawing.Point(21, 260);
            this.pbMinMaxTemp.Name = "pbMinMaxTemp";
            this.pbMinMaxTemp.Size = new System.Drawing.Size(32, 32);
            this.pbMinMaxTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinMaxTemp.TabIndex = 7;
            this.pbMinMaxTemp.TabStop = false;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(238, 110);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.PlaceholderText = "000.00 C";
            this.tbTemperature.Size = new System.Drawing.Size(100, 32);
            this.tbTemperature.TabIndex = 8;
            this.tbTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFeelsLike
            // 
            this.tbFeelsLike.Location = new System.Drawing.Point(238, 185);
            this.tbFeelsLike.Name = "tbFeelsLike";
            this.tbFeelsLike.PlaceholderText = "000.00 C";
            this.tbFeelsLike.Size = new System.Drawing.Size(100, 32);
            this.tbFeelsLike.TabIndex = 9;
            this.tbFeelsLike.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMinMaxTemp
            // 
            this.tbMinMaxTemp.Location = new System.Drawing.Point(238, 260);
            this.tbMinMaxTemp.Name = "tbMinMaxTemp";
            this.tbMinMaxTemp.PlaceholderText = "000.00 / 000.00 C";
            this.tbMinMaxTemp.Size = new System.Drawing.Size(200, 32);
            this.tbMinMaxTemp.TabIndex = 10;
            this.tbMinMaxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGroundLevel
            // 
            this.tbGroundLevel.Location = new System.Drawing.Point(748, 260);
            this.tbGroundLevel.Name = "tbGroundLevel";
            this.tbGroundLevel.PlaceholderText = "0000 hPa";
            this.tbGroundLevel.Size = new System.Drawing.Size(100, 32);
            this.tbGroundLevel.TabIndex = 19;
            this.tbGroundLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSeaLevel
            // 
            this.tbSeaLevel.Location = new System.Drawing.Point(748, 185);
            this.tbSeaLevel.Name = "tbSeaLevel";
            this.tbSeaLevel.PlaceholderText = "0000 hPa";
            this.tbSeaLevel.Size = new System.Drawing.Size(100, 32);
            this.tbSeaLevel.TabIndex = 18;
            this.tbSeaLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(748, 110);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.PlaceholderText = "0000 hPa";
            this.tbPressure.Size = new System.Drawing.Size(100, 32);
            this.tbPressure.TabIndex = 17;
            this.tbPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbGroundLevel
            // 
            this.pbGroundLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbGroundLevel.Image = ((System.Drawing.Image)(resources.GetObject("pbGroundLevel.Image")));
            this.pbGroundLevel.Location = new System.Drawing.Point(531, 260);
            this.pbGroundLevel.Name = "pbGroundLevel";
            this.pbGroundLevel.Size = new System.Drawing.Size(32, 32);
            this.pbGroundLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGroundLevel.TabIndex = 16;
            this.pbGroundLevel.TabStop = false;
            // 
            // pbSeaLevel
            // 
            this.pbSeaLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbSeaLevel.Image = ((System.Drawing.Image)(resources.GetObject("pbSeaLevel.Image")));
            this.pbSeaLevel.Location = new System.Drawing.Point(531, 185);
            this.pbSeaLevel.Name = "pbSeaLevel";
            this.pbSeaLevel.Size = new System.Drawing.Size(32, 32);
            this.pbSeaLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeaLevel.TabIndex = 15;
            this.pbSeaLevel.TabStop = false;
            // 
            // lblGroundLevel
            // 
            this.lblGroundLevel.Location = new System.Drawing.Point(563, 260);
            this.lblGroundLevel.Name = "lblGroundLevel";
            this.lblGroundLevel.Size = new System.Drawing.Size(185, 32);
            this.lblGroundLevel.TabIndex = 14;
            this.lblGroundLevel.Text = "Ground level:";
            this.lblGroundLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeaLevel
            // 
            this.lblSeaLevel.Location = new System.Drawing.Point(563, 185);
            this.lblSeaLevel.Name = "lblSeaLevel";
            this.lblSeaLevel.Size = new System.Drawing.Size(185, 32);
            this.lblSeaLevel.TabIndex = 13;
            this.lblSeaLevel.Text = "Sea level:";
            this.lblSeaLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPressure
            // 
            this.lblPressure.Location = new System.Drawing.Point(563, 110);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(185, 32);
            this.lblPressure.TabIndex = 12;
            this.lblPressure.Text = "Pressure:";
            this.lblPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPressure
            // 
            this.pbPressure.BackColor = System.Drawing.Color.Transparent;
            this.pbPressure.Image = ((System.Drawing.Image)(resources.GetObject("pbPressure.Image")));
            this.pbPressure.Location = new System.Drawing.Point(531, 110);
            this.pbPressure.Name = "pbPressure";
            this.pbPressure.Size = new System.Drawing.Size(32, 32);
            this.pbPressure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPressure.TabIndex = 11;
            this.pbPressure.TabStop = false;
            // 
            // tbVisibility
            // 
            this.tbVisibility.Location = new System.Drawing.Point(287, 480);
            this.tbVisibility.Name = "tbVisibility";
            this.tbVisibility.PlaceholderText = "00000 m";
            this.tbVisibility.Size = new System.Drawing.Size(100, 32);
            this.tbVisibility.TabIndex = 28;
            this.tbVisibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCloudCover
            // 
            this.tbCloudCover.Location = new System.Drawing.Point(287, 405);
            this.tbCloudCover.Name = "tbCloudCover";
            this.tbCloudCover.PlaceholderText = "00%";
            this.tbCloudCover.Size = new System.Drawing.Size(100, 32);
            this.tbCloudCover.TabIndex = 27;
            this.tbCloudCover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(287, 330);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.PlaceholderText = "00%";
            this.tbHumidity.Size = new System.Drawing.Size(100, 32);
            this.tbHumidity.TabIndex = 26;
            this.tbHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbVisibility
            // 
            this.pbVisibility.BackColor = System.Drawing.Color.Transparent;
            this.pbVisibility.Image = ((System.Drawing.Image)(resources.GetObject("pbVisibility.Image")));
            this.pbVisibility.Location = new System.Drawing.Point(70, 480);
            this.pbVisibility.Name = "pbVisibility";
            this.pbVisibility.Size = new System.Drawing.Size(32, 32);
            this.pbVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVisibility.TabIndex = 25;
            this.pbVisibility.TabStop = false;
            // 
            // pbCloudCover
            // 
            this.pbCloudCover.BackColor = System.Drawing.Color.Transparent;
            this.pbCloudCover.Image = ((System.Drawing.Image)(resources.GetObject("pbCloudCover.Image")));
            this.pbCloudCover.Location = new System.Drawing.Point(70, 405);
            this.pbCloudCover.Name = "pbCloudCover";
            this.pbCloudCover.Size = new System.Drawing.Size(32, 32);
            this.pbCloudCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloudCover.TabIndex = 24;
            this.pbCloudCover.TabStop = false;
            // 
            // lblVisibility
            // 
            this.lblVisibility.Location = new System.Drawing.Point(102, 480);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(185, 32);
            this.lblVisibility.TabIndex = 23;
            this.lblVisibility.Text = "Visibility:";
            this.lblVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCloudCover
            // 
            this.lblCloudCover.Location = new System.Drawing.Point(102, 405);
            this.lblCloudCover.Name = "lblCloudCover";
            this.lblCloudCover.Size = new System.Drawing.Size(185, 32);
            this.lblCloudCover.TabIndex = 22;
            this.lblCloudCover.Text = "Cloud cover:";
            this.lblCloudCover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHumidity
            // 
            this.lblHumidity.Location = new System.Drawing.Point(102, 330);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(185, 32);
            this.lblHumidity.TabIndex = 21;
            this.lblHumidity.Text = "Humidity:";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbHumidity
            // 
            this.pbHumidity.BackColor = System.Drawing.Color.Transparent;
            this.pbHumidity.Image = ((System.Drawing.Image)(resources.GetObject("pbHumidity.Image")));
            this.pbHumidity.Location = new System.Drawing.Point(70, 330);
            this.pbHumidity.Name = "pbHumidity";
            this.pbHumidity.Size = new System.Drawing.Size(32, 32);
            this.pbHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumidity.TabIndex = 20;
            this.pbHumidity.TabStop = false;
            // 
            // tbWindDirection
            // 
            this.tbWindDirection.Location = new System.Drawing.Point(700, 480);
            this.tbWindDirection.Name = "tbWindDirection";
            this.tbWindDirection.PlaceholderText = "000";
            this.tbWindDirection.Size = new System.Drawing.Size(110, 32);
            this.tbWindDirection.TabIndex = 37;
            this.tbWindDirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWindGust
            // 
            this.tbWindGust.Location = new System.Drawing.Point(700, 405);
            this.tbWindGust.Name = "tbWindGust";
            this.tbWindGust.PlaceholderText = "00.00 m/s";
            this.tbWindGust.Size = new System.Drawing.Size(110, 32);
            this.tbWindGust.TabIndex = 36;
            this.tbWindGust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWindSpeed
            // 
            this.tbWindSpeed.Location = new System.Drawing.Point(700, 330);
            this.tbWindSpeed.Name = "tbWindSpeed";
            this.tbWindSpeed.PlaceholderText = "00.00 m/s";
            this.tbWindSpeed.Size = new System.Drawing.Size(110, 32);
            this.tbWindSpeed.TabIndex = 35;
            this.tbWindSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbWindDirection
            // 
            this.pbWindDirection.BackColor = System.Drawing.Color.Transparent;
            this.pbWindDirection.Image = ((System.Drawing.Image)(resources.GetObject("pbWindDirection.Image")));
            this.pbWindDirection.Location = new System.Drawing.Point(483, 480);
            this.pbWindDirection.Name = "pbWindDirection";
            this.pbWindDirection.Size = new System.Drawing.Size(32, 32);
            this.pbWindDirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWindDirection.TabIndex = 34;
            this.pbWindDirection.TabStop = false;
            // 
            // pbWindGust
            // 
            this.pbWindGust.BackColor = System.Drawing.Color.Transparent;
            this.pbWindGust.Image = ((System.Drawing.Image)(resources.GetObject("pbWindGust.Image")));
            this.pbWindGust.Location = new System.Drawing.Point(483, 405);
            this.pbWindGust.Name = "pbWindGust";
            this.pbWindGust.Size = new System.Drawing.Size(32, 32);
            this.pbWindGust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWindGust.TabIndex = 33;
            this.pbWindGust.TabStop = false;
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.Location = new System.Drawing.Point(515, 480);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(185, 32);
            this.lblWindDirection.TabIndex = 32;
            this.lblWindDirection.Text = "Wind direction:";
            this.lblWindDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindGust
            // 
            this.lblWindGust.Location = new System.Drawing.Point(515, 405);
            this.lblWindGust.Name = "lblWindGust";
            this.lblWindGust.Size = new System.Drawing.Size(185, 32);
            this.lblWindGust.TabIndex = 31;
            this.lblWindGust.Text = "Wind gusts:";
            this.lblWindGust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Location = new System.Drawing.Point(515, 330);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(185, 32);
            this.lblWindSpeed.TabIndex = 30;
            this.lblWindSpeed.Text = "Wind speed:";
            this.lblWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbWindSpeed
            // 
            this.pbWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.pbWindSpeed.Image = ((System.Drawing.Image)(resources.GetObject("pbWindSpeed.Image")));
            this.pbWindSpeed.Location = new System.Drawing.Point(483, 330);
            this.pbWindSpeed.Name = "pbWindSpeed";
            this.pbWindSpeed.Size = new System.Drawing.Size(32, 32);
            this.pbWindSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWindSpeed.TabIndex = 29;
            this.pbWindSpeed.TabStop = false;
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(20, 20);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(100, 50);
            this.bBack.TabIndex = 38;
            this.bBack.Text = "Back to menu";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tbWindDirection);
            this.Controls.Add(this.tbWindGust);
            this.Controls.Add(this.tbWindSpeed);
            this.Controls.Add(this.pbWindDirection);
            this.Controls.Add(this.pbWindGust);
            this.Controls.Add(this.lblWindDirection);
            this.Controls.Add(this.lblWindGust);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.pbWindSpeed);
            this.Controls.Add(this.tbVisibility);
            this.Controls.Add(this.tbCloudCover);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.pbVisibility);
            this.Controls.Add(this.pbCloudCover);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.lblCloudCover);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.pbHumidity);
            this.Controls.Add(this.tbGroundLevel);
            this.Controls.Add(this.tbSeaLevel);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.pbGroundLevel);
            this.Controls.Add(this.pbSeaLevel);
            this.Controls.Add(this.lblGroundLevel);
            this.Controls.Add(this.lblSeaLevel);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.pbPressure);
            this.Controls.Add(this.tbMinMaxTemp);
            this.Controls.Add(this.tbFeelsLike);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.pbMinMaxTemp);
            this.Controls.Add(this.pbFeelsLike);
            this.Controls.Add(this.lblMinMaxTemp);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.pbTemperature);
            this.Controls.Add(this.pbWeather);
            this.Controls.Add(this.cbCitySelect);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unnamed Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeelsLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroundLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeaLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloudCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindGust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCitySelect;
        private PictureBox pbWeather;
        private PictureBox pbTemperature;
        private Label lblTemperature;
        private Label lblFeelsLike;
        private Label lblMinMaxTemp;
        private PictureBox pbFeelsLike;
        private PictureBox pbMinMaxTemp;
        private TextBox tbTemperature;
        private TextBox tbFeelsLike;
        private TextBox tbMinMaxTemp;
        private TextBox tbGroundLevel;
        private TextBox tbSeaLevel;
        private TextBox tbPressure;
        private PictureBox pbGroundLevel;
        private PictureBox pbSeaLevel;
        private Label lblGroundLevel;
        private Label lblSeaLevel;
        private Label lblPressure;
        private PictureBox pbPressure;
        private TextBox tbVisibility;
        private TextBox tbCloudCover;
        private TextBox tbHumidity;
        private PictureBox pbVisibility;
        private PictureBox pbCloudCover;
        private Label lblVisibility;
        private Label lblCloudCover;
        private Label lblHumidity;
        private PictureBox pbHumidity;
        private TextBox tbWindDirection;
        private TextBox tbWindGust;
        private TextBox tbWindSpeed;
        private PictureBox pbWindDirection;
        private PictureBox pbWindGust;
        private Label lblWindDirection;
        private Label lblWindGust;
        private Label lblWindSpeed;
        private PictureBox pbWindSpeed;
        private Button bBack;
    }
}