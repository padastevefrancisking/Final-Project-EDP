namespace Final_Project_EDP.System_UserControls
{
    partial class Schedules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedules));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.SchedulesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TuteeScheduleButton = new Guna.UI.WinForms.GunaButton();
            this.TutoringScheduleButton = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.SchedulesFlowLayoutPanel);
            this.gunaPanel1.Controls.Add(this.TuteeScheduleButton);
            this.gunaPanel1.Controls.Add(this.TutoringScheduleButton);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1360, 763);
            this.gunaPanel1.TabIndex = 1;
            // 
            // SchedulesFlowLayoutPanel
            // 
            this.SchedulesFlowLayoutPanel.AutoScroll = true;
            this.SchedulesFlowLayoutPanel.Location = new System.Drawing.Point(13, 115);
            this.SchedulesFlowLayoutPanel.Name = "SchedulesFlowLayoutPanel";
            this.SchedulesFlowLayoutPanel.Size = new System.Drawing.Size(1330, 630);
            this.SchedulesFlowLayoutPanel.TabIndex = 2;
            // 
            // TuteeScheduleButton
            // 
            this.TuteeScheduleButton.AnimationHoverSpeed = 0.07F;
            this.TuteeScheduleButton.AnimationSpeed = 0.03F;
            this.TuteeScheduleButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TuteeScheduleButton.BorderColor = System.Drawing.Color.Black;
            this.TuteeScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TuteeScheduleButton.ForeColor = System.Drawing.Color.White;
            this.TuteeScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("TuteeScheduleButton.Image")));
            this.TuteeScheduleButton.ImageSize = new System.Drawing.Size(20, 20);
            this.TuteeScheduleButton.Location = new System.Drawing.Point(1077, 19);
            this.TuteeScheduleButton.Name = "TuteeScheduleButton";
            this.TuteeScheduleButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TuteeScheduleButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TuteeScheduleButton.OnHoverForeColor = System.Drawing.Color.White;
            this.TuteeScheduleButton.OnHoverImage = null;
            this.TuteeScheduleButton.OnPressedColor = System.Drawing.Color.Black;
            this.TuteeScheduleButton.Size = new System.Drawing.Size(266, 70);
            this.TuteeScheduleButton.TabIndex = 1;
            this.TuteeScheduleButton.Text = "Tutee Schedule";
            this.TuteeScheduleButton.Click += new System.EventHandler(this.TuteeScheduleButton_Click);
            // 
            // TutoringScheduleButton
            // 
            this.TutoringScheduleButton.AnimationHoverSpeed = 0.07F;
            this.TutoringScheduleButton.AnimationSpeed = 0.03F;
            this.TutoringScheduleButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TutoringScheduleButton.BorderColor = System.Drawing.Color.Black;
            this.TutoringScheduleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TutoringScheduleButton.ForeColor = System.Drawing.Color.White;
            this.TutoringScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("TutoringScheduleButton.Image")));
            this.TutoringScheduleButton.ImageSize = new System.Drawing.Size(20, 20);
            this.TutoringScheduleButton.Location = new System.Drawing.Point(796, 19);
            this.TutoringScheduleButton.Name = "TutoringScheduleButton";
            this.TutoringScheduleButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TutoringScheduleButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TutoringScheduleButton.OnHoverForeColor = System.Drawing.Color.White;
            this.TutoringScheduleButton.OnHoverImage = null;
            this.TutoringScheduleButton.OnPressedColor = System.Drawing.Color.Black;
            this.TutoringScheduleButton.Size = new System.Drawing.Size(266, 70);
            this.TutoringScheduleButton.TabIndex = 0;
            this.TutoringScheduleButton.Text = "Tutoring Schedule";
            this.TutoringScheduleButton.Click += new System.EventHandler(this.TutoringScheduleButton_Click);
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schedules";
            this.Size = new System.Drawing.Size(1360, 763);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton TutoringScheduleButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton TuteeScheduleButton;
        public System.Windows.Forms.FlowLayoutPanel SchedulesFlowLayoutPanel;
    }
}
