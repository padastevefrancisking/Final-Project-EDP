namespace Final_Project_EDP.System_UserControls
{
    partial class RequestFillup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestFillup));
            this.SubjectTagComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.RequestLocationTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.TutorScheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubjectTagLabel = new Guna.UI.WinForms.GunaLabel();
            this.RequestLocationLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.StartTimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.EndTimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SubjectTagComboBox
            // 
            this.SubjectTagComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SubjectTagComboBox.BaseColor = System.Drawing.Color.White;
            this.SubjectTagComboBox.BorderColor = System.Drawing.Color.Silver;
            this.SubjectTagComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubjectTagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectTagComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubjectTagComboBox.ForeColor = System.Drawing.Color.Black;
            this.SubjectTagComboBox.FormattingEnabled = true;
            this.SubjectTagComboBox.Items.AddRange(new object[] {
            "Mathematics",
            "Computer Science",
            "Calculus",
            "Physics"});
            this.SubjectTagComboBox.Location = new System.Drawing.Point(57, 159);
            this.SubjectTagComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubjectTagComboBox.Name = "SubjectTagComboBox";
            this.SubjectTagComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubjectTagComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SubjectTagComboBox.Size = new System.Drawing.Size(276, 31);
            this.SubjectTagComboBox.TabIndex = 1;
            // 
            // RequestLocationTextbox
            // 
            this.RequestLocationTextbox.BackColor = System.Drawing.Color.White;
            this.RequestLocationTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RequestLocationTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RequestLocationTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RequestLocationTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.RequestLocationTextbox.Location = new System.Drawing.Point(57, 228);
            this.RequestLocationTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RequestLocationTextbox.Name = "RequestLocationTextbox";
            this.RequestLocationTextbox.PasswordChar = '\0';
            this.RequestLocationTextbox.Size = new System.Drawing.Size(277, 37);
            this.RequestLocationTextbox.TabIndex = 3;
            this.RequestLocationTextbox.Text = "gunaLineTextBox1";
            // 
            // TutorScheduleDateTimePicker
            // 
            this.TutorScheduleDateTimePicker.Location = new System.Drawing.Point(57, 299);
            this.TutorScheduleDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TutorScheduleDateTimePicker.Name = "TutorScheduleDateTimePicker";
            this.TutorScheduleDateTimePicker.Size = new System.Drawing.Size(276, 22);
            this.TutorScheduleDateTimePicker.TabIndex = 5;
            // 
            // SubjectTagLabel
            // 
            this.SubjectTagLabel.AutoSize = true;
            this.SubjectTagLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectTagLabel.Location = new System.Drawing.Point(53, 137);
            this.SubjectTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectTagLabel.Name = "SubjectTagLabel";
            this.SubjectTagLabel.Size = new System.Drawing.Size(58, 20);
            this.SubjectTagLabel.TabIndex = 12;
            this.SubjectTagLabel.Text = "Subject";
            // 
            // RequestLocationLabel
            // 
            this.RequestLocationLabel.AutoSize = true;
            this.RequestLocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RequestLocationLabel.Location = new System.Drawing.Point(55, 206);
            this.RequestLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RequestLocationLabel.Name = "RequestLocationLabel";
            this.RequestLocationLabel.Size = new System.Drawing.Size(126, 20);
            this.RequestLocationLabel.TabIndex = 13;
            this.RequestLocationLabel.Text = "Tutoring Location";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(55, 277);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 20);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Tutor Schedule";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartTimeLabel.Location = new System.Drawing.Point(53, 348);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.StartTimeLabel.TabIndex = 16;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndTimeLabel.Location = new System.Drawing.Point(243, 348);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(71, 20);
            this.EndTimeLabel.TabIndex = 17;
            this.EndTimeLabel.Text = "End Time";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(17, 9);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(113, 43);
            this.gunaAdvenceButton1.TabIndex = 11;
            this.gunaAdvenceButton1.Text = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(57, 431);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(277, 52);
            this.gunaButton1.TabIndex = 10;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm:tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(59, 383);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(104, 22);
            this.StartTimePicker.TabIndex = 18;
            this.StartTimePicker.Value = new System.DateTime(2024, 4, 11, 2, 20, 36, 0);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "hh:mm:tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(241, 383);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(92, 22);
            this.EndTimePicker.TabIndex = 19;
            this.EndTimePicker.Value = new System.DateTime(2024, 4, 11, 2, 20, 36, 0);
            // 
            // RequestFillup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.RequestLocationLabel);
            this.Controls.Add(this.SubjectTagLabel);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.TutorScheduleDateTimePicker);
            this.Controls.Add(this.RequestLocationTextbox);
            this.Controls.Add(this.SubjectTagComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RequestFillup";
            this.Size = new System.Drawing.Size(396, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox SubjectTagComboBox;
        private Guna.UI.WinForms.GunaLineTextBox RequestLocationTextbox;
        private System.Windows.Forms.DateTimePicker TutorScheduleDateTimePicker;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaLabel SubjectTagLabel;
        private Guna.UI.WinForms.GunaLabel RequestLocationLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel StartTimeLabel;
        private Guna.UI.WinForms.GunaLabel EndTimeLabel;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
    }
}
