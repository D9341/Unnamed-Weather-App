namespace Unnamed_Weather_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.lblSignup = new System.Windows.Forms.Label();
            this.bSignupForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UNNAMED WEATHER APP - Log in";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Location = new System.Drawing.Point(40, 100);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.PlaceholderText = "Username";
            this.tbUsernameLogin.Size = new System.Drawing.Size(200, 32);
            this.tbUsernameLogin.TabIndex = 1;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(40, 160);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.PlaceholderText = "Password";
            this.tbPasswordLogin.Size = new System.Drawing.Size(200, 32);
            this.tbPasswordLogin.TabIndex = 2;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(90, 220);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(100, 40);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Log in";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSignup.Location = new System.Drawing.Point(12, 300);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(165, 16);
            this.lblSignup.TabIndex = 4;
            this.lblSignup.Text = "Don\'t have an account?";
            // 
            // bSignupForm
            // 
            this.bSignupForm.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSignupForm.Location = new System.Drawing.Point(185, 295);
            this.bSignupForm.Name = "bSignupForm";
            this.bSignupForm.Size = new System.Drawing.Size(80, 25);
            this.bSignupForm.TabIndex = 5;
            this.bSignupForm.Text = "Sign up";
            this.bSignupForm.UseVisualStyleBackColor = true;
            this.bSignupForm.Click += new System.EventHandler(this.bSignupForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.bSignupForm);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UWA - Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox tbUsernameLogin;
        private TextBox tbPasswordLogin;
        private Button bLogin;
        private Label lblSignup;
        private Button bSignupForm;
    }
}