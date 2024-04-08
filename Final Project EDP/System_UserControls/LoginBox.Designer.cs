namespace Final_Project_EDP
{
    partial class LoginBox
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
            this.LoginHeader = new Guna.UI.WinForms.GunaLabel();
            this.RegisterLabel = new Guna.UI.WinForms.GunaLabel();
            this.SignupLinkLabel = new Guna.UI.WinForms.GunaLinkLabel();
            this.EmailAddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.EmailAddressTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordLabel = new Guna.UI.WinForms.GunaLabel();
            this.PasswordTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // LoginHeader
            // 
            this.LoginHeader.AutoSize = true;
            this.LoginHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeader.Location = new System.Drawing.Point(189, 31);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(71, 31);
            this.LoginHeader.TabIndex = 0;
            this.LoginHeader.Text = "Login";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterLabel.Location = new System.Drawing.Point(73, 73);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(187, 20);
            this.RegisterLabel.TabIndex = 1;
            this.RegisterLabel.Text = "Don\'t have an account yet?";
            // 
            // SignupLinkLabel
            // 
            this.SignupLinkLabel.AutoSize = true;
            this.SignupLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignupLinkLabel.Location = new System.Drawing.Point(266, 73);
            this.SignupLinkLabel.Name = "SignupLinkLabel";
            this.SignupLinkLabel.Size = new System.Drawing.Size(97, 20);
            this.SignupLinkLabel.TabIndex = 2;
            this.SignupLinkLabel.TabStop = true;
            this.SignupLinkLabel.Text = "Sign Up Here";
            this.SignupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLinkLabel_LinkClicked);
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailAddressLabel.Location = new System.Drawing.Point(73, 150);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(103, 20);
            this.EmailAddressLabel.TabIndex = 3;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // EmailAddressTextbox
            // 
            this.EmailAddressTextbox.BaseColor = System.Drawing.Color.White;
            this.EmailAddressTextbox.BorderColor = System.Drawing.Color.Silver;
            this.EmailAddressTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailAddressTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailAddressTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailAddressTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailAddressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailAddressTextbox.Location = new System.Drawing.Point(77, 182);
            this.EmailAddressTextbox.Name = "EmailAddressTextbox";
            this.EmailAddressTextbox.PasswordChar = '\0';
            this.EmailAddressTextbox.Size = new System.Drawing.Size(291, 30);
            this.EmailAddressTextbox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordLabel.Location = new System.Drawing.Point(73, 235);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BaseColor = System.Drawing.Color.White;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextbox.Location = new System.Drawing.Point(77, 278);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.Size = new System.Drawing.Size(291, 32);
            this.PasswordTextbox.TabIndex = 6;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(146, 338);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Size = new System.Drawing.Size(160, 42);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailAddressTextbox);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.SignupLinkLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginHeader);
            this.Name = "LoginBox";
            this.Size = new System.Drawing.Size(450, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel LoginHeader;
        private Guna.UI.WinForms.GunaLabel RegisterLabel;
        private Guna.UI.WinForms.GunaLinkLabel SignupLinkLabel;
        private Guna.UI.WinForms.GunaLabel EmailAddressLabel;
        private Guna.UI.WinForms.GunaTextBox EmailAddressTextbox;
        private Guna.UI.WinForms.GunaLabel PasswordLabel;
        private Guna.UI.WinForms.GunaTextBox PasswordTextbox;
        private Guna.UI.WinForms.GunaButton LoginButton;
    }
}
