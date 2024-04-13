namespace Final_Project_EDP.System_UserControls
{
    partial class Dashboard
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
            this.WelcomeDashboardLabel = new Guna.UI.WinForms.GunaLabel();
            this.PendingRequestLabel = new Guna.UI.WinForms.GunaLabel();
            this.PendingRequestsPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.PendingRequestImage = new Guna.UI.WinForms.GunaPictureBox();
            this.PendingAmountPanel = new Guna.UI.WinForms.GunaLabel();
            this.SchedulePanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.ScheduleImage = new Guna.UI.WinForms.GunaPictureBox();
            this.ScheduleAmountLabel = new Guna.UI.WinForms.GunaLabel();
            this.ScheduleLabel = new Guna.UI.WinForms.GunaLabel();
            this.SummaryLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.PendingRequestsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequestImage)).BeginInit();
            this.SchedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeDashboardLabel
            // 
            this.WelcomeDashboardLabel.AutoSize = true;
            this.WelcomeDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WelcomeDashboardLabel.Location = new System.Drawing.Point(22, 26);
            this.WelcomeDashboardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeDashboardLabel.Name = "WelcomeDashboardLabel";
            this.WelcomeDashboardLabel.Size = new System.Drawing.Size(63, 15);
            this.WelcomeDashboardLabel.TabIndex = 0;
            this.WelcomeDashboardLabel.Text = "Welcome, ";
            // 
            // PendingRequestLabel
            // 
            this.PendingRequestLabel.AutoSize = true;
            this.PendingRequestLabel.BackColor = System.Drawing.Color.Transparent;
            this.PendingRequestLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PendingRequestLabel.Location = new System.Drawing.Point(28, 21);
            this.PendingRequestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PendingRequestLabel.Name = "PendingRequestLabel";
            this.PendingRequestLabel.Size = new System.Drawing.Size(51, 15);
            this.PendingRequestLabel.TabIndex = 1;
            this.PendingRequestLabel.Text = "Pending";
            // 
            // PendingRequestsPanel
            // 
            this.PendingRequestsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PendingRequestsPanel.BackColor = System.Drawing.Color.IndianRed;
            this.PendingRequestsPanel.BaseColor = System.Drawing.Color.RosyBrown;
            this.PendingRequestsPanel.Controls.Add(this.PendingRequestImage);
            this.PendingRequestsPanel.Controls.Add(this.PendingAmountPanel);
            this.PendingRequestsPanel.Controls.Add(this.PendingRequestLabel);
            this.PendingRequestsPanel.Location = new System.Drawing.Point(84, 58);
            this.PendingRequestsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PendingRequestsPanel.Name = "PendingRequestsPanel";
            this.PendingRequestsPanel.Radius = 10;
            this.PendingRequestsPanel.Size = new System.Drawing.Size(352, 201);
            this.PendingRequestsPanel.TabIndex = 3;
            // 
            // PendingRequestImage
            // 
            this.PendingRequestImage.BackColor = System.Drawing.Color.Transparent;
            this.PendingRequestImage.BackgroundImage = global::Final_Project_EDP.Properties.Resources.mail_envelope_1024x781;
            this.PendingRequestImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PendingRequestImage.BaseColor = System.Drawing.Color.White;
            this.PendingRequestImage.Location = new System.Drawing.Point(111, 12);
            this.PendingRequestImage.Name = "PendingRequestImage";
            this.PendingRequestImage.Size = new System.Drawing.Size(184, 133);
            this.PendingRequestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PendingRequestImage.TabIndex = 2;
            this.PendingRequestImage.TabStop = false;
            // 
            // PendingAmountPanel
            // 
            this.PendingAmountPanel.AutoSize = true;
            this.PendingAmountPanel.BackColor = System.Drawing.Color.Transparent;
            this.PendingAmountPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PendingAmountPanel.Location = new System.Drawing.Point(28, 107);
            this.PendingAmountPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PendingAmountPanel.Name = "PendingAmountPanel";
            this.PendingAmountPanel.Size = new System.Drawing.Size(51, 15);
            this.PendingAmountPanel.TabIndex = 3;
            this.PendingAmountPanel.Text = "Pending";
            // 
            // SchedulePanel
            // 
            this.SchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchedulePanel.BackColor = System.Drawing.Color.IndianRed;
            this.SchedulePanel.BaseColor = System.Drawing.Color.RosyBrown;
            this.SchedulePanel.Controls.Add(this.ScheduleImage);
            this.SchedulePanel.Controls.Add(this.ScheduleAmountLabel);
            this.SchedulePanel.Controls.Add(this.ScheduleLabel);
            this.SchedulePanel.Location = new System.Drawing.Point(580, 58);
            this.SchedulePanel.Margin = new System.Windows.Forms.Padding(2);
            this.SchedulePanel.Name = "SchedulePanel";
            this.SchedulePanel.Radius = 10;
            this.SchedulePanel.Size = new System.Drawing.Size(352, 201);
            this.SchedulePanel.TabIndex = 4;
            // 
            // ScheduleImage
            // 
            this.ScheduleImage.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleImage.BackgroundImage = global::Final_Project_EDP.Properties.Resources.mail_envelope_1024x781;
            this.ScheduleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScheduleImage.BaseColor = System.Drawing.Color.White;
            this.ScheduleImage.Location = new System.Drawing.Point(113, 12);
            this.ScheduleImage.Name = "ScheduleImage";
            this.ScheduleImage.Size = new System.Drawing.Size(181, 133);
            this.ScheduleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScheduleImage.TabIndex = 2;
            this.ScheduleImage.TabStop = false;
            // 
            // ScheduleAmountLabel
            // 
            this.ScheduleAmountLabel.AutoSize = true;
            this.ScheduleAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleAmountLabel.Location = new System.Drawing.Point(30, 107);
            this.ScheduleAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleAmountLabel.Name = "ScheduleAmountLabel";
            this.ScheduleAmountLabel.Size = new System.Drawing.Size(51, 15);
            this.ScheduleAmountLabel.TabIndex = 3;
            this.ScheduleAmountLabel.Text = "Pending";
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleLabel.Location = new System.Drawing.Point(26, 21);
            this.ScheduleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(55, 15);
            this.ScheduleLabel.TabIndex = 1;
            this.ScheduleLabel.Text = "Schedule";
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SummaryLabel.Location = new System.Drawing.Point(483, 297);
            this.SummaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(58, 15);
            this.SummaryLabel.TabIndex = 5;
            this.SummaryLabel.Text = "Summary";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(65, 273);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(867, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.SchedulePanel);
            this.Controls.Add(this.PendingRequestsPanel);
            this.Controls.Add(this.WelcomeDashboardLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1020, 640);
            this.PendingRequestsPanel.ResumeLayout(false);
            this.PendingRequestsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequestImage)).EndInit();
            this.SchedulePanel.ResumeLayout(false);
            this.SchedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel WelcomeDashboardLabel;
        private Guna.UI.WinForms.GunaLabel PendingRequestLabel;
        private Guna.UI.WinForms.GunaElipsePanel PendingRequestsPanel;
        private Guna.UI.WinForms.GunaLabel PendingAmountPanel;
        private Guna.UI.WinForms.GunaPictureBox PendingRequestImage;
        private Guna.UI.WinForms.GunaElipsePanel SchedulePanel;
        private Guna.UI.WinForms.GunaPictureBox ScheduleImage;
        private Guna.UI.WinForms.GunaLabel ScheduleAmountLabel;
        private Guna.UI.WinForms.GunaLabel ScheduleLabel;
        private Guna.UI.WinForms.GunaLabel SummaryLabel;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}
