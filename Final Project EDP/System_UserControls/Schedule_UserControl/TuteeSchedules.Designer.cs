namespace Final_Project_EDP.System_UserControls.Schedule_UserControl
{
    partial class TuteeSchedules
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
            this.LocationLabel = new Guna.UI.WinForms.GunaLabel();
            this.TimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.DescriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.SubjectsLabel = new Guna.UI.WinForms.GunaLabel();
            this.TuteeCountLabel = new Guna.UI.WinForms.GunaLabel();
            this.DenyButton = new Guna.UI.WinForms.GunaImageButton();
            this.DetailsButton = new Guna.UI.WinForms.GunaImageButton();
            this.AcceptButton = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocationLabel.Location = new System.Drawing.Point(109, 91);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(86, 20);
            this.LocationLabel.TabIndex = 13;
            this.LocationLabel.Text = "<Location>";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeLabel.Location = new System.Drawing.Point(109, 111);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 20);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "<Start> - <End>";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(109, 42);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(105, 20);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "<Description>";
            // 
            // SubjectsLabel
            // 
            this.SubjectsLabel.AutoSize = true;
            this.SubjectsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectsLabel.Location = new System.Drawing.Point(109, 22);
            this.SubjectsLabel.Name = "SubjectsLabel";
            this.SubjectsLabel.Size = new System.Drawing.Size(144, 20);
            this.SubjectsLabel.TabIndex = 10;
            this.SubjectsLabel.Text = "<Subjects> Tutoring";
            // 
            // TuteeCountLabel
            // 
            this.TuteeCountLabel.AutoSize = true;
            this.TuteeCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TuteeCountLabel.Location = new System.Drawing.Point(109, 131);
            this.TuteeCountLabel.Name = "TuteeCountLabel";
            this.TuteeCountLabel.Size = new System.Drawing.Size(105, 20);
            this.TuteeCountLabel.TabIndex = 15;
            this.TuteeCountLabel.Text = "<TuteeCount>";
            // 
            // DenyButton
            // 
            this.DenyButton.Image = global::Final_Project_EDP.Properties.Resources.mail_envelope_1024x781;
            this.DenyButton.ImageSize = new System.Drawing.Size(64, 64);
            this.DenyButton.Location = new System.Drawing.Point(1242, 101);
            this.DenyButton.Name = "DenyButton";
            this.DenyButton.OnHoverImage = null;
            this.DenyButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.DenyButton.Size = new System.Drawing.Size(64, 64);
            this.DenyButton.TabIndex = 14;
            this.DenyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Image = global::Final_Project_EDP.Properties.Resources.LoginBackground;
            this.DetailsButton.ImageSize = new System.Drawing.Size(64, 64);
            this.DetailsButton.Location = new System.Drawing.Point(1082, 101);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.OnHoverImage = null;
            this.DetailsButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.DetailsButton.Size = new System.Drawing.Size(64, 64);
            this.DetailsButton.TabIndex = 9;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Image = global::Final_Project_EDP.Properties.Resources.tumblr_a04393f37004450c2dd6899d9c887edc_e4c1cda1_540__1_;
            this.AcceptButton.ImageSize = new System.Drawing.Size(64, 64);
            this.AcceptButton.Location = new System.Drawing.Point(1161, 101);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.OnHoverImage = null;
            this.AcceptButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.AcceptButton.Size = new System.Drawing.Size(64, 64);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // TuteeSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TuteeCountLabel);
            this.Controls.Add(this.DenyButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectsLabel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "TuteeSchedules";
            this.Size = new System.Drawing.Size(1335, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel LocationLabel;
        private Guna.UI.WinForms.GunaLabel TimeLabel;
        private Guna.UI.WinForms.GunaLabel DescriptionLabel;
        private Guna.UI.WinForms.GunaLabel SubjectsLabel;
        private Guna.UI.WinForms.GunaImageButton DetailsButton;
        private Guna.UI.WinForms.GunaImageButton AcceptButton;
        private Guna.UI.WinForms.GunaImageButton DenyButton;
        private Guna.UI.WinForms.GunaLabel TuteeCountLabel;
    }
}
