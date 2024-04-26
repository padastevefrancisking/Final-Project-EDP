namespace Final_Project_EDP.System_Forms.Subforms
{
    partial class ScheduleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDetails));
            this.ExitDetails = new Guna.UI.WinForms.GunaButton();
            this.SubjectLabel = new Guna.UI.WinForms.GunaLabel();
            this.TutorLabel = new Guna.UI.WinForms.GunaLabel();
            this.DescriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.ScheduleDayLabel = new Guna.UI.WinForms.GunaLabel();
            this.TimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.TutorRemarksLabel = new Guna.UI.WinForms.GunaLabel();
            this.ScheduleStatusLabel = new Guna.UI.WinForms.GunaLabel();
            this.TuteeLabel = new Guna.UI.WinForms.GunaLabel();
            this.TuteeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LocationLabel = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // ExitDetails
            // 
            this.ExitDetails.AnimationHoverSpeed = 0.07F;
            this.ExitDetails.AnimationSpeed = 0.03F;
            this.ExitDetails.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExitDetails.BorderColor = System.Drawing.Color.Black;
            this.ExitDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitDetails.ForeColor = System.Drawing.Color.White;
            this.ExitDetails.Image = ((System.Drawing.Image)(resources.GetObject("ExitDetails.Image")));
            this.ExitDetails.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitDetails.Location = new System.Drawing.Point(547, 12);
            this.ExitDetails.Name = "ExitDetails";
            this.ExitDetails.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ExitDetails.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitDetails.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitDetails.OnHoverImage = null;
            this.ExitDetails.OnPressedColor = System.Drawing.Color.Black;
            this.ExitDetails.Size = new System.Drawing.Size(41, 42);
            this.ExitDetails.TabIndex = 0;
            this.ExitDetails.Click += new System.EventHandler(this.ExitDetails_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectLabel.Location = new System.Drawing.Point(35, 91);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(139, 20);
            this.SubjectLabel.TabIndex = 1;
            this.SubjectLabel.Text = "<Subject Tutorials>";
            // 
            // TutorLabel
            // 
            this.TutorLabel.AutoSize = true;
            this.TutorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TutorLabel.Location = new System.Drawing.Point(35, 121);
            this.TutorLabel.Name = "TutorLabel";
            this.TutorLabel.Size = new System.Drawing.Size(64, 20);
            this.TutorLabel.TabIndex = 2;
            this.TutorLabel.Text = "<Tutor>";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(35, 153);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(105, 20);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "<Description>";
            // 
            // ScheduleDayLabel
            // 
            this.ScheduleDayLabel.AutoSize = true;
            this.ScheduleDayLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleDayLabel.Location = new System.Drawing.Point(35, 213);
            this.ScheduleDayLabel.Name = "ScheduleDayLabel";
            this.ScheduleDayLabel.Size = new System.Drawing.Size(55, 20);
            this.ScheduleDayLabel.TabIndex = 4;
            this.ScheduleDayLabel.Text = "<Day>";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeLabel.Location = new System.Drawing.Point(35, 247);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 20);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "<Start> - <End>";
            // 
            // TutorRemarksLabel
            // 
            this.TutorRemarksLabel.AutoSize = true;
            this.TutorRemarksLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TutorRemarksLabel.Location = new System.Drawing.Point(35, 279);
            this.TutorRemarksLabel.Name = "TutorRemarksLabel";
            this.TutorRemarksLabel.Size = new System.Drawing.Size(85, 20);
            this.TutorRemarksLabel.TabIndex = 6;
            this.TutorRemarksLabel.Text = "<Remarks>";
            // 
            // ScheduleStatusLabel
            // 
            this.ScheduleStatusLabel.AutoSize = true;
            this.ScheduleStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleStatusLabel.Location = new System.Drawing.Point(35, 309);
            this.ScheduleStatusLabel.Name = "ScheduleStatusLabel";
            this.ScheduleStatusLabel.Size = new System.Drawing.Size(129, 20);
            this.ScheduleStatusLabel.TabIndex = 7;
            this.ScheduleStatusLabel.Text = "<ScheduleStatus>";
            // 
            // TuteeLabel
            // 
            this.TuteeLabel.AutoSize = true;
            this.TuteeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TuteeLabel.Location = new System.Drawing.Point(35, 345);
            this.TuteeLabel.Name = "TuteeLabel";
            this.TuteeLabel.Size = new System.Drawing.Size(64, 20);
            this.TuteeLabel.TabIndex = 8;
            this.TuteeLabel.Text = "<Tutor>";
            // 
            // TuteeFlowLayoutPanel
            // 
            this.TuteeFlowLayoutPanel.Location = new System.Drawing.Point(39, 384);
            this.TuteeFlowLayoutPanel.Name = "TuteeFlowLayoutPanel";
            this.TuteeFlowLayoutPanel.Size = new System.Drawing.Size(516, 419);
            this.TuteeFlowLayoutPanel.TabIndex = 9;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LocationLabel.Location = new System.Drawing.Point(35, 182);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(86, 20);
            this.LocationLabel.TabIndex = 10;
            this.LocationLabel.Text = "<Location>";
            // 
            // ScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 900);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.TuteeFlowLayoutPanel);
            this.Controls.Add(this.TuteeLabel);
            this.Controls.Add(this.ScheduleStatusLabel);
            this.Controls.Add(this.TutorRemarksLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ScheduleDayLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TutorLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ExitDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton ExitDetails;
        private Guna.UI.WinForms.GunaLabel SubjectLabel;
        private Guna.UI.WinForms.GunaLabel TutorLabel;
        private Guna.UI.WinForms.GunaLabel DescriptionLabel;
        private Guna.UI.WinForms.GunaLabel ScheduleDayLabel;
        private Guna.UI.WinForms.GunaLabel TimeLabel;
        private Guna.UI.WinForms.GunaLabel TutorRemarksLabel;
        private Guna.UI.WinForms.GunaLabel ScheduleStatusLabel;
        private Guna.UI.WinForms.GunaLabel TuteeLabel;
        private System.Windows.Forms.FlowLayoutPanel TuteeFlowLayoutPanel;
        private Guna.UI.WinForms.GunaLabel LocationLabel;
    }
}