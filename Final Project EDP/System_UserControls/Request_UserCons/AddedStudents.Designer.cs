namespace Final_Project_EDP.System_UserControls.Request_UserCons
{
    partial class AddedStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddedStudents));
            this.CompleteNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ImageBox = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.RemoveTuteeButton = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompleteNameLabel
            // 
            this.CompleteNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteNameLabel.AutoSize = true;
            this.CompleteNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CompleteNameLabel.Location = new System.Drawing.Point(103, 24);
            this.CompleteNameLabel.Name = "CompleteNameLabel";
            this.CompleteNameLabel.Size = new System.Drawing.Size(86, 20);
            this.CompleteNameLabel.TabIndex = 5;
            this.CompleteNameLabel.Text = "gunaLabel1";
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.BaseColor = System.Drawing.Color.White;
            this.ImageBox.Image = ((System.Drawing.Image)(resources.GetObject("ImageBox.Image")));
            this.ImageBox.Location = new System.Drawing.Point(3, 3);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(74, 74);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 4;
            this.ImageBox.TabStop = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.RemoveTuteeButton);
            this.gunaElipsePanel1.Controls.Add(this.ImageBox);
            this.gunaElipsePanel1.Controls.Add(this.CompleteNameLabel);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(309, 80);
            this.gunaElipsePanel1.TabIndex = 8;
            // 
            // RemoveTuteeButton
            // 
            this.RemoveTuteeButton.AnimationHoverSpeed = 0.07F;
            this.RemoveTuteeButton.AnimationSpeed = 0.03F;
            this.RemoveTuteeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RemoveTuteeButton.BorderColor = System.Drawing.Color.Black;
            this.RemoveTuteeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveTuteeButton.ForeColor = System.Drawing.Color.White;
            this.RemoveTuteeButton.Image = null;
            this.RemoveTuteeButton.ImageSize = new System.Drawing.Size(52, 52);
            this.RemoveTuteeButton.Location = new System.Drawing.Point(235, 3);
            this.RemoveTuteeButton.Name = "RemoveTuteeButton";
            this.RemoveTuteeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RemoveTuteeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RemoveTuteeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.RemoveTuteeButton.OnHoverImage = null;
            this.RemoveTuteeButton.OnPressedColor = System.Drawing.Color.Black;
            this.RemoveTuteeButton.Size = new System.Drawing.Size(71, 74);
            this.RemoveTuteeButton.TabIndex = 6;
            this.RemoveTuteeButton.Text = "X";
            this.RemoveTuteeButton.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // AddedStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "AddedStudents";
            this.Size = new System.Drawing.Size(309, 80);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox ImageBox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        public Guna.UI.WinForms.GunaLabel CompleteNameLabel;
        private Guna.UI.WinForms.GunaCircleButton RemoveTuteeButton;
    }
}
