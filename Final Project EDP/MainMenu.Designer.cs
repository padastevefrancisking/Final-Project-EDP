namespace Final_Project_EDP
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Login = new Guna.UI.WinForms.GunaPanel();
            this.LoginBackground = new Guna.UI.WinForms.GunaPanel();
            this.Exit = new Guna.UI.WinForms.GunaButton();
            this.LoginLabel = new Guna.UI.WinForms.GunaLabel();
            this.Login.SuspendLayout();
            this.LoginBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.SystemColors.Control;
            this.Login.Controls.Add(this.LoginLabel);
            this.Login.Location = new System.Drawing.Point(291, 63);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 316);
            this.Login.TabIndex = 0;
            // 
            // LoginBackground
            // 
            this.LoginBackground.BackgroundImage = global::Final_Project_EDP.Properties.Resources.LoginBackground;
            this.LoginBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBackground.Controls.Add(this.Exit);
            this.LoginBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBackground.Location = new System.Drawing.Point(0, 0);
            this.LoginBackground.Name = "LoginBackground";
            this.LoginBackground.Size = new System.Drawing.Size(733, 457);
            this.LoginBackground.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.AnimationHoverSpeed = 0.07F;
            this.Exit.AnimationSpeed = 0.03F;
            this.Exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Exit.BorderColor = System.Drawing.Color.Black;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(662, 12);
            this.Exit.Name = "Exit";
            this.Exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit.OnHoverForeColor = System.Drawing.Color.White;
            this.Exit.OnHoverImage = null;
            this.Exit.OnPressedColor = System.Drawing.Color.Black;
            this.Exit.Size = new System.Drawing.Size(59, 42);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "gunaButton1";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginLabel.Location = new System.Drawing.Point(40, 11);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(86, 20);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "gunaLabel1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 457);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.LoginBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Login;
        private Guna.UI.WinForms.GunaPanel LoginBackground;
        private Guna.UI.WinForms.GunaLabel LoginLabel;
        private Guna.UI.WinForms.GunaButton Exit;
    }
}

