namespace Final_Project_EDP.System_UserControls.LoginAndSignUp_UserCons
{
    partial class ForgotPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.ForgotPasswordEmailAddressTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.EmailAddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.ForgotPasswordLoginButton = new Guna.UI.WinForms.GunaButton();
            this.SendOTPButton = new Guna.UI.WinForms.GunaButton();
            this.OTPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.ForgotPasswordHeaderLabel = new Guna.UI.WinForms.GunaLabel();
            this.OTPLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.ForgotPasswordEmailAddressTextbox);
            this.gunaPanel1.Controls.Add(this.EmailAddressLabel);
            this.gunaPanel1.Controls.Add(this.ForgotPasswordLoginButton);
            this.gunaPanel1.Controls.Add(this.SendOTPButton);
            this.gunaPanel1.Controls.Add(this.OTPTextBox);
            this.gunaPanel1.Controls.Add(this.ForgotPasswordHeaderLabel);
            this.gunaPanel1.Controls.Add(this.OTPLabel);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(430, 591);
            this.gunaPanel1.TabIndex = 0;
            // 
            // ForgotPasswordEmailAddressTextbox
            // 
            this.ForgotPasswordEmailAddressTextbox.BaseColor = System.Drawing.Color.White;
            this.ForgotPasswordEmailAddressTextbox.BorderColor = System.Drawing.Color.Silver;
            this.ForgotPasswordEmailAddressTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForgotPasswordEmailAddressTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.ForgotPasswordEmailAddressTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ForgotPasswordEmailAddressTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ForgotPasswordEmailAddressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForgotPasswordEmailAddressTextbox.Location = new System.Drawing.Point(16, 198);
            this.ForgotPasswordEmailAddressTextbox.Name = "ForgotPasswordEmailAddressTextbox";
            this.ForgotPasswordEmailAddressTextbox.PasswordChar = '\0';
            this.ForgotPasswordEmailAddressTextbox.Size = new System.Drawing.Size(397, 38);
            this.ForgotPasswordEmailAddressTextbox.TabIndex = 6;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailAddressLabel.Location = new System.Drawing.Point(12, 175);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(103, 20);
            this.EmailAddressLabel.TabIndex = 5;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // ForgotPasswordLoginButton
            // 
            this.ForgotPasswordLoginButton.AnimationHoverSpeed = 0.07F;
            this.ForgotPasswordLoginButton.AnimationSpeed = 0.03F;
            this.ForgotPasswordLoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ForgotPasswordLoginButton.BorderColor = System.Drawing.Color.Black;
            this.ForgotPasswordLoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForgotPasswordLoginButton.ForeColor = System.Drawing.Color.White;
            this.ForgotPasswordLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("ForgotPasswordLoginButton.Image")));
            this.ForgotPasswordLoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ForgotPasswordLoginButton.Location = new System.Drawing.Point(125, 317);
            this.ForgotPasswordLoginButton.Name = "ForgotPasswordLoginButton";
            this.ForgotPasswordLoginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ForgotPasswordLoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ForgotPasswordLoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ForgotPasswordLoginButton.OnHoverImage = null;
            this.ForgotPasswordLoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.ForgotPasswordLoginButton.Size = new System.Drawing.Size(160, 42);
            this.ForgotPasswordLoginButton.TabIndex = 4;
            this.ForgotPasswordLoginButton.Text = "Login";
            this.ForgotPasswordLoginButton.Click += new System.EventHandler(this.ForgotPasswordLoginButton_Click);
            // 
            // SendOTPButton
            // 
            this.SendOTPButton.AnimationHoverSpeed = 0.07F;
            this.SendOTPButton.AnimationSpeed = 0.03F;
            this.SendOTPButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SendOTPButton.BorderColor = System.Drawing.Color.Black;
            this.SendOTPButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendOTPButton.ForeColor = System.Drawing.Color.White;
            this.SendOTPButton.Image = ((System.Drawing.Image)(resources.GetObject("SendOTPButton.Image")));
            this.SendOTPButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SendOTPButton.Location = new System.Drawing.Point(291, 262);
            this.SendOTPButton.Name = "SendOTPButton";
            this.SendOTPButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SendOTPButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SendOTPButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SendOTPButton.OnHoverImage = null;
            this.SendOTPButton.OnPressedColor = System.Drawing.Color.Black;
            this.SendOTPButton.Size = new System.Drawing.Size(122, 38);
            this.SendOTPButton.TabIndex = 3;
            this.SendOTPButton.Text = "Send OTP";
            this.SendOTPButton.Click += new System.EventHandler(this.SendOTPButton_Click);
            // 
            // OTPTextBox
            // 
            this.OTPTextBox.BaseColor = System.Drawing.Color.White;
            this.OTPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.OTPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.OTPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OTPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.OTPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OTPTextBox.Location = new System.Drawing.Point(16, 262);
            this.OTPTextBox.Name = "OTPTextBox";
            this.OTPTextBox.PasswordChar = '\0';
            this.OTPTextBox.Size = new System.Drawing.Size(269, 38);
            this.OTPTextBox.TabIndex = 2;
            // 
            // ForgotPasswordHeaderLabel
            // 
            this.ForgotPasswordHeaderLabel.AutoSize = true;
            this.ForgotPasswordHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForgotPasswordHeaderLabel.Location = new System.Drawing.Point(160, 51);
            this.ForgotPasswordHeaderLabel.Name = "ForgotPasswordHeaderLabel";
            this.ForgotPasswordHeaderLabel.Size = new System.Drawing.Size(125, 20);
            this.ForgotPasswordHeaderLabel.TabIndex = 1;
            this.ForgotPasswordHeaderLabel.Text = "Forgot Password?";
            // 
            // OTPLabel
            // 
            this.OTPLabel.AutoSize = true;
            this.OTPLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OTPLabel.Location = new System.Drawing.Point(12, 239);
            this.OTPLabel.Name = "OTPLabel";
            this.OTPLabel.Size = new System.Drawing.Size(35, 20);
            this.OTPLabel.TabIndex = 0;
            this.OTPLabel.Text = "OTP";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(16, 16);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(46, 42);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(430, 591);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton SendOTPButton;
        private Guna.UI.WinForms.GunaTextBox OTPTextBox;
        private Guna.UI.WinForms.GunaLabel ForgotPasswordHeaderLabel;
        private Guna.UI.WinForms.GunaLabel OTPLabel;
        private Guna.UI.WinForms.GunaButton ForgotPasswordLoginButton;
        private Guna.UI.WinForms.GunaTextBox ForgotPasswordEmailAddressTextbox;
        private Guna.UI.WinForms.GunaLabel EmailAddressLabel;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
