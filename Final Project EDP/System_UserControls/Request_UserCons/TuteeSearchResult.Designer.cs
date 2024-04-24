namespace Final_Project_EDP.System_UserControls
{
    partial class TuteeSearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuteeSearchResult));
            this.TuteeSearchResultBackgroundPanel = new Guna.UI.WinForms.GunaPanel();
            this.AddAccountButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DegreeProgramLabel = new Guna.UI.WinForms.GunaLabel();
            this.UsernameLabel = new Guna.UI.WinForms.GunaLabel();
            this.CompleteNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProfilePictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.TuteeSearchResultBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TuteeSearchResultBackgroundPanel
            // 
            this.TuteeSearchResultBackgroundPanel.Controls.Add(this.AddAccountButton);
            this.TuteeSearchResultBackgroundPanel.Controls.Add(this.DegreeProgramLabel);
            this.TuteeSearchResultBackgroundPanel.Controls.Add(this.UsernameLabel);
            this.TuteeSearchResultBackgroundPanel.Controls.Add(this.CompleteNameLabel);
            this.TuteeSearchResultBackgroundPanel.Controls.Add(this.ProfilePictureBox);
            this.TuteeSearchResultBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuteeSearchResultBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.TuteeSearchResultBackgroundPanel.Name = "TuteeSearchResultBackgroundPanel";
            this.TuteeSearchResultBackgroundPanel.Size = new System.Drawing.Size(372, 151);
            this.TuteeSearchResultBackgroundPanel.TabIndex = 0;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.AnimationHoverSpeed = 0.07F;
            this.AddAccountButton.AnimationSpeed = 0.03F;
            this.AddAccountButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddAccountButton.BorderColor = System.Drawing.Color.Black;
            this.AddAccountButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddAccountButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddAccountButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddAccountButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddAccountButton.CheckedImage")));
            this.AddAccountButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddAccountButton.ForeColor = System.Drawing.Color.White;
            this.AddAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("AddAccountButton.Image")));
            this.AddAccountButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddAccountButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddAccountButton.Location = new System.Drawing.Point(285, 121);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddAccountButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddAccountButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddAccountButton.OnHoverImage = null;
            this.AddAccountButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddAccountButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddAccountButton.Size = new System.Drawing.Size(75, 14);
            this.AddAccountButton.TabIndex = 5;
            this.AddAccountButton.Text = "Add";
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // DegreeProgramLabel
            // 
            this.DegreeProgramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DegreeProgramLabel.AutoSize = true;
            this.DegreeProgramLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DegreeProgramLabel.Location = new System.Drawing.Point(212, 76);
            this.DegreeProgramLabel.Name = "DegreeProgramLabel";
            this.DegreeProgramLabel.Size = new System.Drawing.Size(86, 20);
            this.DegreeProgramLabel.TabIndex = 3;
            this.DegreeProgramLabel.Text = "gunaLabel2";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameLabel.Location = new System.Drawing.Point(212, 35);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(86, 20);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "gunaLabel2";
            // 
            // CompleteNameLabel
            // 
            this.CompleteNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteNameLabel.AutoSize = true;
            this.CompleteNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CompleteNameLabel.Location = new System.Drawing.Point(212, 15);
            this.CompleteNameLabel.Name = "CompleteNameLabel";
            this.CompleteNameLabel.Size = new System.Drawing.Size(86, 20);
            this.CompleteNameLabel.TabIndex = 1;
            this.CompleteNameLabel.Text = "gunaLabel1";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePictureBox.BaseColor = System.Drawing.Color.White;
            this.ProfilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePictureBox.Image")));
            this.ProfilePictureBox.Location = new System.Drawing.Point(15, 15);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(114, 121);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // TuteeSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TuteeSearchResultBackgroundPanel);
            this.Name = "TuteeSearchResult";
            this.Size = new System.Drawing.Size(372, 151);
            this.TuteeSearchResultBackgroundPanel.ResumeLayout(false);
            this.TuteeSearchResultBackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel TuteeSearchResultBackgroundPanel;
        private Guna.UI.WinForms.GunaPictureBox ProfilePictureBox;
        private Guna.UI.WinForms.GunaLabel DegreeProgramLabel;
        private Guna.UI.WinForms.GunaLabel CompleteNameLabel;
        public Guna.UI.WinForms.GunaLabel UsernameLabel;
        private Guna.UI.WinForms.GunaAdvenceButton AddAccountButton;
    }
}
