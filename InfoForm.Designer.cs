namespace Unnamed_Weather_App
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.bBack = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(20, 20);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(100, 50);
            this.bBack.TabIndex = 40;
            this.bBack.Text = "Back to menu";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lblInfo1
            // 
            this.lblInfo1.Location = new System.Drawing.Point(40, 120);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(800, 75);
            this.lblInfo1.TabIndex = 41;
            this.lblInfo1.Text = "Unnamed Weather App is a simple weather application that can be used to see a gen" +
    "eral weather forecast of any city in the world.";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo2
            // 
            this.lblInfo2.Location = new System.Drawing.Point(40, 195);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(800, 50);
            this.lblInfo2.TabIndex = 42;
            this.lblInfo2.Text = "This app was made by Jan Jankoski.";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo3
            // 
            this.lblInfo3.Location = new System.Drawing.Point(40, 245);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(800, 75);
            this.lblInfo3.TabIndex = 43;
            this.lblInfo3.Text = "Unnamed Weather app uses the OpenWeather \"One Call\" API to fetch weather data. Fo" +
    "r more information, visit openweathermap.org!";
            this.lblInfo3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo4
            // 
            this.lblInfo4.Location = new System.Drawing.Point(40, 320);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(800, 80);
            this.lblInfo4.TabIndex = 44;
            this.lblInfo4.Text = resources.GetString("lblInfo4.Text");
            this.lblInfo4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unnamed Weather App";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bBack;
        private Label lblInfo1;
        private Label lblInfo2;
        private Label lblInfo3;
        private Label lblInfo4;
    }
}