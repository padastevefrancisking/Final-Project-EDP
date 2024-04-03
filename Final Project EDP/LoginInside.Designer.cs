namespace Final_Project_EDP
{
    partial class LoginInside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInside));
            this.LoginForm = new Guna.UI.WinForms.GunaPanel();
            this.AlternativeSignup = new System.Windows.Forms.Label();
            this.PasswordTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordLabel = new Guna.UI.WinForms.GunaLabel();
            this.SignupLinkLabel = new Guna.UI.WinForms.GunaLinkLabel();
            this.UsernameLabel = new Guna.UI.WinForms.GunaLabel();
            this.QuestionLabel = new Guna.UI.WinForms.GunaLabel();
            this.LoginHeader = new Guna.UI.WinForms.GunaLabel();
            this.GoogleButton = new Guna.UI.WinForms.GunaButton();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.UsernameTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.LoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.LoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.LoginForm.Controls.Add(this.UsernameTextbox);
            this.LoginForm.Controls.Add(this.LoginButton);
            this.LoginForm.Controls.Add(this.GoogleButton);
            this.LoginForm.Controls.Add(this.AlternativeSignup);
            this.LoginForm.Controls.Add(this.PasswordTextbox);
            this.LoginForm.Controls.Add(this.PasswordLabel);
            this.LoginForm.Controls.Add(this.SignupLinkLabel);
            this.LoginForm.Controls.Add(this.UsernameLabel);
            this.LoginForm.Controls.Add(this.QuestionLabel);
            this.LoginForm.Controls.Add(this.LoginHeader);
            this.LoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginForm.Location = new System.Drawing.Point(0, 0);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(493, 650);
            this.LoginForm.TabIndex = 0;
            // 
            // AlternativeSignup
            // 
            this.AlternativeSignup.AutoSize = true;
            this.AlternativeSignup.Location = new System.Drawing.Point(197, 439);
            this.AlternativeSignup.Name = "AlternativeSignup";
            this.AlternativeSignup.Size = new System.Drawing.Size(100, 16);
            this.AlternativeSignup.TabIndex = 7;
            this.AlternativeSignup.Text = "or sign up using";
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
            this.PasswordTextbox.Location = new System.Drawing.Point(78, 241);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '\0';
            this.PasswordTextbox.Size = new System.Drawing.Size(331, 32);
            this.PasswordTextbox.TabIndex = 5;
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordLabel.Location = new System.Drawing.Point(74, 207);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // SignupLinkLabel
            // 
            this.SignupLinkLabel.AutoSize = true;
            this.SignupLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignupLinkLabel.Location = new System.Drawing.Point(291, 82);
            this.SignupLinkLabel.Name = "SignupLinkLabel";
            this.SignupLinkLabel.Size = new System.Drawing.Size(95, 20);
            this.SignupLinkLabel.TabIndex = 3;
            this.SignupLinkLabel.TabStop = true;
            this.SignupLinkLabel.Text = "Sign up here.";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameLabel.Location = new System.Drawing.Point(74, 129);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuestionLabel.Location = new System.Drawing.Point(98, 82);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(187, 20);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Don\'t have an account yet?";
            // 
            // LoginHeader
            // 
            this.LoginHeader.AutoSize = true;
            this.LoginHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginHeader.Location = new System.Drawing.Point(215, 36);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(46, 20);
            this.LoginHeader.TabIndex = 0;
            this.LoginHeader.Text = "Login";
            // 
            // GoogleButton
            // 
            this.GoogleButton.AnimationHoverSpeed = 0.07F;
            this.GoogleButton.AnimationSpeed = 0.03F;
            this.GoogleButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GoogleButton.BorderColor = System.Drawing.Color.Black;
            this.GoogleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoogleButton.ForeColor = System.Drawing.Color.White;
            this.GoogleButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleButton.Image")));
            this.GoogleButton.ImageSize = new System.Drawing.Size(20, 20);
            this.GoogleButton.Location = new System.Drawing.Point(169, 467);
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.GoogleButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GoogleButton.OnHoverForeColor = System.Drawing.Color.White;
            this.GoogleButton.OnHoverImage = null;
            this.GoogleButton.OnPressedColor = System.Drawing.Color.Black;
            this.GoogleButton.Radius = 20;
            this.GoogleButton.Size = new System.Drawing.Size(160, 42);
            this.GoogleButton.TabIndex = 8;
            this.GoogleButton.Text = "Google";
            this.GoogleButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(169, 308);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Size = new System.Drawing.Size(160, 42);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BaseColor = System.Drawing.Color.White;
            this.UsernameTextbox.BorderColor = System.Drawing.Color.Silver;
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.UsernameTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextbox.Location = new System.Drawing.Point(78, 161);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.Size = new System.Drawing.Size(331, 33);
            this.UsernameTextbox.TabIndex = 10;
            // 
            // LoginInside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 650);
            this.Controls.Add(this.LoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginInside";
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel LoginForm;
        private Guna.UI.WinForms.GunaLabel LoginHeader;
        private Guna.UI.WinForms.GunaLabel QuestionLabel;
        private Guna.UI.WinForms.GunaLabel UsernameLabel;
        private Guna.UI.WinForms.GunaLinkLabel SignupLinkLabel;
        private Guna.UI.WinForms.GunaTextBox PasswordTextbox;
        private Guna.UI.WinForms.GunaLabel PasswordLabel;
        private System.Windows.Forms.Label AlternativeSignup;
        private Guna.UI.WinForms.GunaButton GoogleButton;
        private Guna.UI.WinForms.GunaTextBox UsernameTextbox;
        private Guna.UI.WinForms.GunaButton LoginButton;
    }
}