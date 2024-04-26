namespace Final_Project_EDP.System_Forms.Subforms
{
    partial class ScheduleFillUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleFillUp));
            this.BackButton = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.AnimationHoverSpeed = 0.07F;
            this.BackButton.AnimationSpeed = 0.03F;
            this.BackButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BackButton.BorderColor = System.Drawing.Color.Black;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageSize = new System.Drawing.Size(20, 20);
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(44, 42);
            this.BackButton.TabIndex = 0;
            // 
            // ScheduleFillUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 900);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleFillUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleFillUp";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton BackButton;
    }
}