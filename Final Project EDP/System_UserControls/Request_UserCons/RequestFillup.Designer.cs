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
            this.TutorScheduleLabel = new Guna.UI.WinForms.GunaLabel();
            this.StartTimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.EndTimeLabel = new Guna.UI.WinForms.GunaLabel();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemarksLabel = new Guna.UI.WinForms.GunaLabel();
            this.RemarksTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.TuteesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddStudentsFlowPanel = new Guna.UI.WinForms.GunaLabel();
            this.SoloRequestCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SearchTuteeTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.SearchboxResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BackButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.MakeRequestButton = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.SubjectTagComboBox.Location = new System.Drawing.Point(57, 82);
            this.SubjectTagComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectTagComboBox.Name = "SubjectTagComboBox";
            this.SubjectTagComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubjectTagComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SubjectTagComboBox.Size = new System.Drawing.Size(502, 31);
            this.SubjectTagComboBox.TabIndex = 1;
            // 
            // RequestLocationTextbox
            // 
            this.RequestLocationTextbox.BackColor = System.Drawing.Color.White;
            this.RequestLocationTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RequestLocationTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RequestLocationTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RequestLocationTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.RequestLocationTextbox.Location = new System.Drawing.Point(57, 270);
            this.RequestLocationTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.RequestLocationTextbox.Name = "RequestLocationTextbox";
            this.RequestLocationTextbox.PasswordChar = '\0';
            this.RequestLocationTextbox.Size = new System.Drawing.Size(502, 37);
            this.RequestLocationTextbox.TabIndex = 3;
            // 
            // TutorScheduleDateTimePicker
            // 
            this.TutorScheduleDateTimePicker.Location = new System.Drawing.Point(57, 333);
            this.TutorScheduleDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TutorScheduleDateTimePicker.Name = "TutorScheduleDateTimePicker";
            this.TutorScheduleDateTimePicker.Size = new System.Drawing.Size(502, 22);
            this.TutorScheduleDateTimePicker.TabIndex = 5;
            this.TutorScheduleDateTimePicker.Value = new System.DateTime(2024, 4, 13, 23, 24, 36, 0);
            // 
            // SubjectTagLabel
            // 
            this.SubjectTagLabel.AutoSize = true;
            this.SubjectTagLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectTagLabel.Location = new System.Drawing.Point(53, 60);
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
            this.RequestLocationLabel.Location = new System.Drawing.Point(55, 240);
            this.RequestLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RequestLocationLabel.Name = "RequestLocationLabel";
            this.RequestLocationLabel.Size = new System.Drawing.Size(126, 20);
            this.RequestLocationLabel.TabIndex = 13;
            this.RequestLocationLabel.Text = "Tutoring Location";
            // 
            // TutorScheduleLabel
            // 
            this.TutorScheduleLabel.AutoSize = true;
            this.TutorScheduleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TutorScheduleLabel.Location = new System.Drawing.Point(55, 311);
            this.TutorScheduleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorScheduleLabel.Name = "TutorScheduleLabel";
            this.TutorScheduleLabel.Size = new System.Drawing.Size(108, 20);
            this.TutorScheduleLabel.TabIndex = 15;
            this.TutorScheduleLabel.Text = "Tutor Schedule";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartTimeLabel.Location = new System.Drawing.Point(53, 371);
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
            this.EndTimeLabel.Location = new System.Drawing.Point(463, 371);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(71, 20);
            this.EndTimeLabel.TabIndex = 17;
            this.EndTimeLabel.Text = "End Time";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm:tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(59, 406);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(104, 22);
            this.StartTimePicker.TabIndex = 18;
            this.StartTimePicker.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "hh:mm:tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(467, 406);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(92, 22);
            this.EndTimePicker.TabIndex = 19;
            this.EndTimePicker.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemarksLabel.Location = new System.Drawing.Point(53, 443);
            this.RemarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(65, 20);
            this.RemarksLabel.TabIndex = 21;
            this.RemarksLabel.Text = "Remarks";
            // 
            // RemarksTextbox
            // 
            this.RemarksTextbox.BackColor = System.Drawing.Color.White;
            this.RemarksTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemarksTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RemarksTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemarksTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.RemarksTextbox.Location = new System.Drawing.Point(56, 478);
            this.RemarksTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.RemarksTextbox.Name = "RemarksTextbox";
            this.RemarksTextbox.PasswordChar = '\0';
            this.RemarksTextbox.Size = new System.Drawing.Size(503, 75);
            this.RemarksTextbox.TabIndex = 22;
            // 
            // TuteesLayoutPanel
            // 
            this.TuteesLayoutPanel.AutoScroll = true;
            this.TuteesLayoutPanel.Location = new System.Drawing.Point(59, 158);
            this.TuteesLayoutPanel.Name = "TuteesLayoutPanel";
            this.TuteesLayoutPanel.Size = new System.Drawing.Size(398, 79);
            this.TuteesLayoutPanel.TabIndex = 24;
            // 
            // AddStudentsFlowPanel
            // 
            this.AddStudentsFlowPanel.AutoSize = true;
            this.AddStudentsFlowPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddStudentsFlowPanel.Location = new System.Drawing.Point(53, 121);
            this.AddStudentsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddStudentsFlowPanel.Name = "AddStudentsFlowPanel";
            this.AddStudentsFlowPanel.Size = new System.Drawing.Size(127, 20);
            this.AddStudentsFlowPanel.TabIndex = 25;
            this.AddStudentsFlowPanel.Text = "Included Students";
            // 
            // SoloRequestCheckBox
            // 
            this.SoloRequestCheckBox.BaseColor = System.Drawing.Color.White;
            this.SoloRequestCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.SoloRequestCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SoloRequestCheckBox.FillColor = System.Drawing.Color.White;
            this.SoloRequestCheckBox.Location = new System.Drawing.Point(187, 121);
            this.SoloRequestCheckBox.Name = "SoloRequestCheckBox";
            this.SoloRequestCheckBox.Size = new System.Drawing.Size(111, 20);
            this.SoloRequestCheckBox.TabIndex = 27;
            this.SoloRequestCheckBox.Text = "Solo Request";
            this.SoloRequestCheckBox.CheckedChanged += new System.EventHandler(this.SoloRequestCheckBox_CheckedChanged);
            // 
            // SearchTuteeTextbox
            // 
            this.SearchTuteeTextbox.BackColor = System.Drawing.Color.White;
            this.SearchTuteeTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTuteeTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SearchTuteeTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTuteeTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.SearchTuteeTextbox.Location = new System.Drawing.Point(304, 120);
            this.SearchTuteeTextbox.Name = "SearchTuteeTextbox";
            this.SearchTuteeTextbox.PasswordChar = '\0';
            this.SearchTuteeTextbox.Size = new System.Drawing.Size(255, 30);
            this.SearchTuteeTextbox.TabIndex = 29;
            this.SearchTuteeTextbox.TextChanged += new System.EventHandler(this.SearchTuteeTextbox_TextChanged);
            // 
            // SearchboxResultPanel
            // 
            this.SearchboxResultPanel.AutoScroll = true;
            this.SearchboxResultPanel.Location = new System.Drawing.Point(304, 146);
            this.SearchboxResultPanel.Name = "SearchboxResultPanel";
            this.SearchboxResultPanel.Size = new System.Drawing.Size(255, 91);
            this.SearchboxResultPanel.TabIndex = 30;
            // 
            // BackButton
            // 
            this.BackButton.AnimationHoverSpeed = 0.07F;
            this.BackButton.AnimationSpeed = 0.03F;
            this.BackButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BackButton.BorderColor = System.Drawing.Color.Black;
            this.BackButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BackButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.BackButton.CheckedForeColor = System.Drawing.Color.White;
            this.BackButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BackButton.CheckedImage")));
            this.BackButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageSize = new System.Drawing.Size(20, 20);
            this.BackButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BackButton.Location = new System.Drawing.Point(17, 9);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BackButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BackButton.OnHoverImage = null;
            this.BackButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BackButton.OnPressedColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(113, 43);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "gunaAdvenceButton1";
            this.BackButton.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // MakeRequestButton
            // 
            this.MakeRequestButton.AnimationHoverSpeed = 0.07F;
            this.MakeRequestButton.AnimationSpeed = 0.03F;
            this.MakeRequestButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MakeRequestButton.BorderColor = System.Drawing.Color.Black;
            this.MakeRequestButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MakeRequestButton.ForeColor = System.Drawing.Color.White;
            this.MakeRequestButton.Image = ((System.Drawing.Image)(resources.GetObject("MakeRequestButton.Image")));
            this.MakeRequestButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MakeRequestButton.Location = new System.Drawing.Point(57, 561);
            this.MakeRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.MakeRequestButton.Name = "MakeRequestButton";
            this.MakeRequestButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MakeRequestButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MakeRequestButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MakeRequestButton.OnHoverImage = null;
            this.MakeRequestButton.OnPressedColor = System.Drawing.Color.Black;
            this.MakeRequestButton.Size = new System.Drawing.Size(502, 52);
            this.MakeRequestButton.TabIndex = 10;
            this.MakeRequestButton.Text = "gunaButton1";
            this.MakeRequestButton.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(587, 28);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(17, 23);
            this.gunaAdvenceButton1.TabIndex = 32;
            this.gunaAdvenceButton1.Text = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click_1);
            // 
            // RequestFillup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.SearchboxResultPanel);
            this.Controls.Add(this.SearchTuteeTextbox);
            this.Controls.Add(this.SoloRequestCheckBox);
            this.Controls.Add(this.AddStudentsFlowPanel);
            this.Controls.Add(this.TuteesLayoutPanel);
            this.Controls.Add(this.RemarksTextbox);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.TutorScheduleLabel);
            this.Controls.Add(this.RequestLocationLabel);
            this.Controls.Add(this.SubjectTagLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MakeRequestButton);
            this.Controls.Add(this.TutorScheduleDateTimePicker);
            this.Controls.Add(this.RequestLocationTextbox);
            this.Controls.Add(this.SubjectTagComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestFillup";
            this.Size = new System.Drawing.Size(666, 665);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox SubjectTagComboBox;
        private Guna.UI.WinForms.GunaLineTextBox RequestLocationTextbox;
        private System.Windows.Forms.DateTimePicker TutorScheduleDateTimePicker;
        private Guna.UI.WinForms.GunaButton MakeRequestButton;
        private Guna.UI.WinForms.GunaAdvenceButton BackButton;
        private Guna.UI.WinForms.GunaLabel SubjectTagLabel;
        private Guna.UI.WinForms.GunaLabel RequestLocationLabel;
        private Guna.UI.WinForms.GunaLabel TutorScheduleLabel;
        private Guna.UI.WinForms.GunaLabel StartTimeLabel;
        private Guna.UI.WinForms.GunaLabel EndTimeLabel;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private Guna.UI.WinForms.GunaLabel RemarksLabel;
        private Guna.UI.WinForms.GunaLineTextBox RemarksTextbox;
        private Guna.UI.WinForms.GunaLabel AddStudentsFlowPanel;
        private Guna.UI.WinForms.GunaCheckBox SoloRequestCheckBox;
        private Guna.UI.WinForms.GunaLineTextBox SearchTuteeTextbox;
        public System.Windows.Forms.FlowLayoutPanel SearchboxResultPanel;
        public System.Windows.Forms.FlowLayoutPanel TuteesLayoutPanel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}
