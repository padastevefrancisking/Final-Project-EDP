namespace Final_Project_EDP.System_UserControls.Schedule_UserControl
{
    partial class ScheduleStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleStudents));
            this.CompleteNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ImageBox = new Guna.UI.WinForms.GunaPictureBox();
            this.DegreeAndYearLabel = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CompleteNameLabel
            // 
            this.CompleteNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteNameLabel.AutoSize = true;
            this.CompleteNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CompleteNameLabel.Location = new System.Drawing.Point(103, 12);
            this.CompleteNameLabel.Name = "CompleteNameLabel";
            this.CompleteNameLabel.Size = new System.Drawing.Size(134, 20);
            this.CompleteNameLabel.TabIndex = 8;
            this.CompleteNameLabel.Text = "<CompleteName>";
            // 
            // ImageBox
            // 
            this.ImageBox.BaseColor = System.Drawing.Color.White;
            this.ImageBox.Image = ((System.Drawing.Image)(resources.GetObject("ImageBox.Image")));
            this.ImageBox.Location = new System.Drawing.Point(12, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(74, 74);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 7;
            this.ImageBox.TabStop = false;
            // 
            // DegreeAndYearLabel
            // 
            this.DegreeAndYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DegreeAndYearLabel.AutoSize = true;
            this.DegreeAndYearLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DegreeAndYearLabel.Location = new System.Drawing.Point(103, 48);
            this.DegreeAndYearLabel.Name = "DegreeAndYearLabel";
            this.DegreeAndYearLabel.Size = new System.Drawing.Size(134, 20);
            this.DegreeAndYearLabel.TabIndex = 9;
            this.DegreeAndYearLabel.Text = "<CompleteName>";
            // 
            // ScheduleStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DegreeAndYearLabel);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.CompleteNameLabel);
            this.Name = "ScheduleStudents";
            this.Size = new System.Drawing.Size(501, 98);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox ImageBox;
        public Guna.UI.WinForms.GunaLabel CompleteNameLabel;
        public Guna.UI.WinForms.GunaLabel DegreeAndYearLabel;
    }
}
