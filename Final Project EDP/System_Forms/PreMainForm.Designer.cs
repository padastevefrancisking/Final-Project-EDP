namespace Final_Project_EDP
{
    partial class PreMainForm
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
            this.LoginBackground = new Guna.UI.WinForms.GunaPanel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Exit = new Guna.UI.WinForms.GunaButton();
            this.LoginBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBackground
            // 
            this.LoginBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBackground.Controls.Add(this.LoginPanel);
            this.LoginBackground.Controls.Add(this.Exit);
            this.LoginBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBackground.Location = new System.Drawing.Point(0, 0);
            this.LoginBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBackground.Name = "LoginBackground";
            this.LoginBackground.Size = new System.Drawing.Size(1167, 718);
            this.LoginBackground.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.Location = new System.Drawing.Point(316, 65);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(566, 580);
            this.LoginPanel.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AnimationHoverSpeed = 0.07F;
            this.Exit.AnimationSpeed = 0.03F;
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.BaseColor = System.Drawing.Color.Transparent;
            this.Exit.BorderColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.Turquoise;
            this.Exit.Image = null;
            this.Exit.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(1103, 10);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit.OnHoverForeColor = System.Drawing.Color.White;
            this.Exit.OnHoverImage = null;
            this.Exit.OnPressedColor = System.Drawing.Color.Black;
            this.Exit.Size = new System.Drawing.Size(44, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PreMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.LoginBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PreMainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LoginBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel LoginBackground;
        private Guna.UI.WinForms.GunaButton Exit;
        public System.Windows.Forms.Panel LoginPanel;
    }
}

