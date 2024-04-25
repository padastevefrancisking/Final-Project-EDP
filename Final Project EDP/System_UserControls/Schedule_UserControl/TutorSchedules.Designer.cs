namespace Final_Project_EDP.System_UserControls.Schedule_UserControl
{
    partial class TutorSchedules
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
            this.CancelButton = new Guna.UI.WinForms.GunaImageButton();
            this.DetailsButton = new Guna.UI.WinForms.GunaImageButton();
            this.SubjectsLabel = new Guna.UI.WinForms.GunaLabel();
            this.DescriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.TimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::Final_Project_EDP.Properties.Resources.tumblr_a04393f37004450c2dd6899d9c887edc_e4c1cda1_540__1_;
            this.CancelButton.ImageSize = new System.Drawing.Size(64, 64);
            this.CancelButton.Location = new System.Drawing.Point(1254, 103);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnHoverImage = null;
            this.CancelButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.CancelButton.Size = new System.Drawing.Size(64, 64);
            this.CancelButton.TabIndex = 0;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Image = global::Final_Project_EDP.Properties.Resources.LoginBackground;
            this.DetailsButton.ImageSize = new System.Drawing.Size(64, 64);
            this.DetailsButton.Location = new System.Drawing.Point(1175, 103);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.OnHoverImage = null;
            this.DetailsButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.DetailsButton.Size = new System.Drawing.Size(64, 64);
            this.DetailsButton.TabIndex = 3;
            // 
            // SubjectsLabel
            // 
            this.SubjectsLabel.AutoSize = true;
            this.SubjectsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectsLabel.Location = new System.Drawing.Point(202, 24);
            this.SubjectsLabel.Name = "SubjectsLabel";
            this.SubjectsLabel.Size = new System.Drawing.Size(144, 20);
            this.SubjectsLabel.TabIndex = 4;
            this.SubjectsLabel.Text = "<Subjects> Tutoring";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(202, 44);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(105, 20);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "<Description>";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeLabel.Location = new System.Drawing.Point(202, 113);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 20);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "<Start> - <End>";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(202, 93);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(105, 20);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "<Description>";
            // 
            // TutorSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectsLabel);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "TutorSchedules";
            this.Size = new System.Drawing.Size(1335, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton CancelButton;
        private Guna.UI.WinForms.GunaImageButton DetailsButton;
        private Guna.UI.WinForms.GunaLabel SubjectsLabel;
        private Guna.UI.WinForms.GunaLabel DescriptionLabel;
        private Guna.UI.WinForms.GunaLabel TimeLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
