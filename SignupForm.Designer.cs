namespace Unnamed_Weather_App
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.bLoginForm = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.bSignup = new System.Windows.Forms.Button();
            this.tbPasswordSignup = new System.Windows.Forms.TextBox();
            this.tbUsernameSignup = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbVerify = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bLoginForm
            // 
            this.bLoginForm.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bLoginForm.Location = new System.Drawing.Point(198, 308);
            this.bLoginForm.Name = "bLoginForm";
            this.bLoginForm.Size = new System.Drawing.Size(60, 25);
            this.bLoginForm.TabIndex = 11;
            this.bLoginForm.Text = "Log in";
            this.bLoginForm.UseVisualStyleBackColor = true;
            this.bLoginForm.Click += new System.EventHandler(this.bLoginForm_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(12, 312);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(180, 16);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Already have an account?";
            // 
            // bSignup
            // 
            this.bSignup.Enabled = false;
            this.bSignup.Location = new System.Drawing.Point(90, 250);
            this.bSignup.Name = "bSignup";
            this.bSignup.Size = new System.Drawing.Size(100, 40);
            this.bSignup.TabIndex = 9;
            this.bSignup.Text = "Sign up";
            this.bSignup.UseVisualStyleBackColor = true;
            this.bSignup.Click += new System.EventHandler(this.bSignup_Click);
            // 
            // tbPasswordSignup
            // 
            this.tbPasswordSignup.Location = new System.Drawing.Point(40, 150);
            this.tbPasswordSignup.Name = "tbPasswordSignup";
            this.tbPasswordSignup.PasswordChar = '*';
            this.tbPasswordSignup.PlaceholderText = "Password";
            this.tbPasswordSignup.Size = new System.Drawing.Size(200, 32);
            this.tbPasswordSignup.TabIndex = 8;
            // 
            // tbUsernameSignup
            // 
            this.tbUsernameSignup.Location = new System.Drawing.Point(40, 90);
            this.tbUsernameSignup.Name = "tbUsernameSignup";
            this.tbUsernameSignup.PlaceholderText = "Username";
            this.tbUsernameSignup.Size = new System.Drawing.Size(200, 32);
            this.tbUsernameSignup.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 60);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "UNNAMED WEATHER APP - Sign up";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbVerify
            // 
            this.cbVerify.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVerify.Location = new System.Drawing.Point(40, 200);
            this.cbVerify.Name = "cbVerify";
            this.cbVerify.Size = new System.Drawing.Size(200, 45);
            this.cbVerify.TabIndex = 12;
            this.cbVerify.Text = "I have read and agree to the terms of service.";
            this.cbVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbVerify.UseVisualStyleBackColor = true;
            this.cbVerify.CheckedChanged += new System.EventHandler(this.cbVerify_CheckedChanged);
            // 
            // SignupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.cbVerify);
            this.Controls.Add(this.bLoginForm);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.bSignup);
            this.Controls.Add(this.tbPasswordSignup);
            this.Controls.Add(this.tbUsernameSignup);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UWA - Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bLoginForm;
        private Label lblLogin;
        private Button bSignup;
        private TextBox tbPasswordSignup;
        private TextBox tbUsernameSignup;
        private Label lblTitle;
        private CheckBox cbVerify;
    }
}