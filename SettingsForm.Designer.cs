namespace Unnamed_Weather_App
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.bBack = new System.Windows.Forms.Button();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.tbCityId = new System.Windows.Forms.TextBox();
            this.lblCityId = new System.Windows.Forms.Label();
            this.bAddCity = new System.Windows.Forms.Button();
            this.pbAddCity = new System.Windows.Forms.PictureBox();
            this.pbChangePassword = new System.Windows.Forms.PictureBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewPassRep = new System.Windows.Forms.TextBox();
            this.bChangePass = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(20, 20);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(100, 50);
            this.bBack.TabIndex = 39;
            this.bBack.Text = "Back to menu";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lblAddCity
            // 
            this.lblAddCity.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddCity.Location = new System.Drawing.Point(165, 100);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(150, 40);
            this.lblAddCity.TabIndex = 40;
            this.lblAddCity.Text = "Add city";
            this.lblAddCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(95, 175);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.PlaceholderText = "City name";
            this.tbCityName.Size = new System.Drawing.Size(250, 32);
            this.tbCityName.TabIndex = 41;
            // 
            // tbCityId
            // 
            this.tbCityId.Location = new System.Drawing.Point(95, 250);
            this.tbCityId.Name = "tbCityId";
            this.tbCityId.PlaceholderText = "City ID*";
            this.tbCityId.Size = new System.Drawing.Size(250, 32);
            this.tbCityId.TabIndex = 42;
            // 
            // lblCityId
            // 
            this.lblCityId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCityId.Location = new System.Drawing.Point(45, 300);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(350, 110);
            this.lblCityId.TabIndex = 43;
            this.lblCityId.Text = "*City ID is a number which the app uses to fetch weather data about a city. The I" +
    "D number of any city can be found by searching the city at: openweathermap.org";
            this.lblCityId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAddCity
            // 
            this.bAddCity.Location = new System.Drawing.Point(160, 450);
            this.bAddCity.Name = "bAddCity";
            this.bAddCity.Size = new System.Drawing.Size(120, 35);
            this.bAddCity.TabIndex = 44;
            this.bAddCity.Text = "Add city";
            this.bAddCity.UseVisualStyleBackColor = true;
            this.bAddCity.Click += new System.EventHandler(this.bAddCity_Click);
            // 
            // pbAddCity
            // 
            this.pbAddCity.BackColor = System.Drawing.Color.Transparent;
            this.pbAddCity.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCity.Image")));
            this.pbAddCity.Location = new System.Drawing.Point(125, 100);
            this.pbAddCity.Name = "pbAddCity";
            this.pbAddCity.Size = new System.Drawing.Size(40, 40);
            this.pbAddCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCity.TabIndex = 45;
            this.pbAddCity.TabStop = false;
            // 
            // pbChangePassword
            // 
            this.pbChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.pbChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("pbChangePassword.Image")));
            this.pbChangePassword.Location = new System.Drawing.Point(480, 100);
            this.pbChangePassword.Name = "pbChangePassword";
            this.pbChangePassword.Size = new System.Drawing.Size(40, 40);
            this.pbChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChangePassword.TabIndex = 47;
            this.pbChangePassword.TabStop = false;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChangePassword.Location = new System.Drawing.Point(520, 100);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(300, 40);
            this.lblChangePassword.TabIndex = 46;
            this.lblChangePassword.Text = "Change password";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(525, 175);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.PlaceholderText = "Current password";
            this.tbCurrentPass.Size = new System.Drawing.Size(250, 32);
            this.tbCurrentPass.TabIndex = 48;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(525, 250);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.PlaceholderText = "New password";
            this.tbNewPass.Size = new System.Drawing.Size(250, 32);
            this.tbNewPass.TabIndex = 49;
            // 
            // tbNewPassRep
            // 
            this.tbNewPassRep.Location = new System.Drawing.Point(525, 300);
            this.tbNewPassRep.Name = "tbNewPassRep";
            this.tbNewPassRep.PasswordChar = '*';
            this.tbNewPassRep.PlaceholderText = "Repeat new password";
            this.tbNewPassRep.Size = new System.Drawing.Size(250, 32);
            this.tbNewPassRep.TabIndex = 50;
            // 
            // bChangePass
            // 
            this.bChangePass.Location = new System.Drawing.Point(590, 425);
            this.bChangePass.Name = "bChangePass";
            this.bChangePass.Size = new System.Drawing.Size(120, 65);
            this.bChangePass.TabIndex = 51;
            this.bChangePass.Text = "Change password";
            this.bChangePass.UseVisualStyleBackColor = true;
            this.bChangePass.Click += new System.EventHandler(this.bChangePass_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(455, 360);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(245, 32);
            this.lblUsername.TabIndex = 52;
            this.lblUsername.Text = "Currently logged in as:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(700, 360);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 32);
            this.tbUsername.TabIndex = 53;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.bChangePass);
            this.Controls.Add(this.tbNewPassRep);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurrentPass);
            this.Controls.Add(this.pbChangePassword);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.pbAddCity);
            this.Controls.Add(this.bAddCity);
            this.Controls.Add(this.lblCityId);
            this.Controls.Add(this.tbCityId);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.lblAddCity);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unnamed Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bBack;
        private Label lblAddCity;
        private TextBox tbCityName;
        private TextBox tbCityId;
        private Label lblCityId;
        private Button bAddCity;
        private PictureBox pbAddCity;
        private PictureBox pbChangePassword;
        private Label lblChangePassword;
        private TextBox tbCurrentPass;
        private TextBox tbNewPass;
        private TextBox tbNewPassRep;
        private Button bChangePass;
        private Label lblUsername;
        private TextBox tbUsername;
    }
}