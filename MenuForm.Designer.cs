namespace Unnamed_Weather_App
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.bWeatherForm = new System.Windows.Forms.Button();
            this.bSettingsForm = new System.Windows.Forms.Button();
            this.bInfoForm = new System.Windows.Forms.Button();
            this.bExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UNNAMED WEATHER APP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bWeatherForm
            // 
            this.bWeatherForm.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bWeatherForm.Location = new System.Drawing.Point(250, 200);
            this.bWeatherForm.Name = "bWeatherForm";
            this.bWeatherForm.Size = new System.Drawing.Size(400, 45);
            this.bWeatherForm.TabIndex = 1;
            this.bWeatherForm.Text = "Check the weather";
            this.bWeatherForm.UseVisualStyleBackColor = true;
            this.bWeatherForm.Click += new System.EventHandler(this.bWeatherForm_Click);
            // 
            // bSettingsForm
            // 
            this.bSettingsForm.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSettingsForm.Location = new System.Drawing.Point(250, 275);
            this.bSettingsForm.Name = "bSettingsForm";
            this.bSettingsForm.Size = new System.Drawing.Size(400, 45);
            this.bSettingsForm.TabIndex = 2;
            this.bSettingsForm.Text = "Settings";
            this.bSettingsForm.UseVisualStyleBackColor = true;
            this.bSettingsForm.Click += new System.EventHandler(this.bSettingsForm_Click);
            // 
            // bInfoForm
            // 
            this.bInfoForm.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bInfoForm.Location = new System.Drawing.Point(250, 350);
            this.bInfoForm.Name = "bInfoForm";
            this.bInfoForm.Size = new System.Drawing.Size(400, 45);
            this.bInfoForm.TabIndex = 3;
            this.bInfoForm.Text = "Information and credits";
            this.bInfoForm.UseVisualStyleBackColor = true;
            this.bInfoForm.Click += new System.EventHandler(this.bInfoForm_Click);
            // 
            // bExitApp
            // 
            this.bExitApp.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitApp.Location = new System.Drawing.Point(350, 450);
            this.bExitApp.Name = "bExitApp";
            this.bExitApp.Size = new System.Drawing.Size(200, 45);
            this.bExitApp.TabIndex = 4;
            this.bExitApp.Text = "Exit";
            this.bExitApp.UseVisualStyleBackColor = true;
            this.bExitApp.Click += new System.EventHandler(this.bExitApp_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.bExitApp);
            this.Controls.Add(this.bInfoForm);
            this.Controls.Add(this.bSettingsForm);
            this.Controls.Add(this.bWeatherForm);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unnamed Weather App";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Button bWeatherForm;
        private Button bSettingsForm;
        private Button bInfoForm;
        private Button bExitApp;
    }
}