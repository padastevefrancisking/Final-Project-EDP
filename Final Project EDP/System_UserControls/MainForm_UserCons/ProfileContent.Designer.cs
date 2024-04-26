namespace Final_Project_EDP.System_UserControls.Profile_UserCons
{
    partial class ProfileContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileContent));
            this.HeaderPanel = new Guna.UI.WinForms.GunaPanel();
            this.EditButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CompleteNameLabel = new Guna.UI.WinForms.GunaLineTextBox();
            this.ProfilePictureBox = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.FooterPanel = new Guna.UI.WinForms.GunaPanel();
            this.EditProfileButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.EmailTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.EmailLabel = new Guna.UI.WinForms.GunaLabel();
            this.LastNameTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.LastNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.FirstNameTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.FirstNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.YearLevelComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.DegreeProgramTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.YearLevelLabel = new Guna.UI.WinForms.GunaLabel();
            this.DegreeProgramLabel = new Guna.UI.WinForms.GunaLabel();
            this.ChangePictureButton = new Guna.UI.WinForms.GunaButton();
            this.YearLevelTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.CancelEditButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPanel.Controls.Add(this.ChangePictureButton);
            this.HeaderPanel.Controls.Add(this.EditButton);
            this.HeaderPanel.Controls.Add(this.CompleteNameLabel);
            this.HeaderPanel.Controls.Add(this.ProfilePictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1026, 310);
            this.HeaderPanel.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.AnimationHoverSpeed = 0.07F;
            this.EditButton.AnimationSpeed = 0.03F;
            this.EditButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EditButton.BorderColor = System.Drawing.Color.Black;
            this.EditButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditButton.CheckedForeColor = System.Drawing.Color.White;
            this.EditButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditButton.CheckedImage")));
            this.EditButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EditButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditButton.Location = new System.Drawing.Point(967, 15);
            this.EditButton.Name = "EditButton";
            this.EditButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EditButton.OnHoverImage = null;
            this.EditButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditButton.OnPressedColor = System.Drawing.Color.Black;
            this.EditButton.Size = new System.Drawing.Size(42, 42);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "gunaAdvenceButton1";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CompleteNameLabel
            // 
            this.CompleteNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompleteNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompleteNameLabel.Enabled = false;
            this.CompleteNameLabel.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CompleteNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteNameLabel.LineColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompleteNameLabel.Location = new System.Drawing.Point(275, 108);
            this.CompleteNameLabel.Name = "CompleteNameLabel";
            this.CompleteNameLabel.PasswordChar = '\0';
            this.CompleteNameLabel.Size = new System.Drawing.Size(600, 74);
            this.CompleteNameLabel.TabIndex = 2;
            this.CompleteNameLabel.Text = "gunaLineTextBox1";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BaseColor = System.Drawing.Color.White;
            this.ProfilePictureBox.Location = new System.Drawing.Point(51, 50);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(200, 200);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 1;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.UseTransfarantBackground = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FooterPanel.Controls.Add(this.CancelEditButton);
            this.FooterPanel.Controls.Add(this.YearLevelTextbox);
            this.FooterPanel.Controls.Add(this.EditProfileButton);
            this.FooterPanel.Controls.Add(this.EmailTextbox);
            this.FooterPanel.Controls.Add(this.EmailLabel);
            this.FooterPanel.Controls.Add(this.LastNameTextbox);
            this.FooterPanel.Controls.Add(this.LastNameLabel);
            this.FooterPanel.Controls.Add(this.FirstNameTextbox);
            this.FooterPanel.Controls.Add(this.FirstNameLabel);
            this.FooterPanel.Controls.Add(this.YearLevelComboBox);
            this.FooterPanel.Controls.Add(this.DegreeProgramTextbox);
            this.FooterPanel.Controls.Add(this.YearLevelLabel);
            this.FooterPanel.Controls.Add(this.DegreeProgramLabel);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.Location = new System.Drawing.Point(0, 310);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1026, 365);
            this.FooterPanel.TabIndex = 1;
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.AnimationHoverSpeed = 0.07F;
            this.EditProfileButton.AnimationSpeed = 0.03F;
            this.EditProfileButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EditProfileButton.BorderColor = System.Drawing.Color.Black;
            this.EditProfileButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.EditProfileButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.EditProfileButton.CheckedForeColor = System.Drawing.Color.White;
            this.EditProfileButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("EditProfileButton.CheckedImage")));
            this.EditProfileButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.EditProfileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditProfileButton.ForeColor = System.Drawing.Color.White;
            this.EditProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("EditProfileButton.Image")));
            this.EditProfileButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EditProfileButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditProfileButton.Location = new System.Drawing.Point(752, 243);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditProfileButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditProfileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EditProfileButton.OnHoverImage = null;
            this.EditProfileButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.EditProfileButton.OnPressedColor = System.Drawing.Color.Black;
            this.EditProfileButton.Size = new System.Drawing.Size(226, 42);
            this.EditProfileButton.TabIndex = 4;
            this.EditProfileButton.Text = "Edit Profile";
            this.EditProfileButton.Visible = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailTextbox.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTextbox.Location = new System.Drawing.Point(752, 37);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.PasswordChar = '\0';
            this.EmailTextbox.ReadOnly = true;
            this.EmailTextbox.Size = new System.Drawing.Size(226, 58);
            this.EmailTextbox.TabIndex = 11;
            this.EmailTextbox.Text = "gunaLineTextBox2";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailLabel.Location = new System.Drawing.Point(713, 14);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(150, 20);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Linked Email Address";
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LastNameTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastNameTextbox.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNameTextbox.Location = new System.Drawing.Point(51, 115);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.PasswordChar = '\0';
            this.LastNameTextbox.ReadOnly = true;
            this.LastNameTextbox.Size = new System.Drawing.Size(226, 58);
            this.LastNameTextbox.TabIndex = 9;
            this.LastNameTextbox.Text = "gunaLineTextBox2";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastNameLabel.Location = new System.Drawing.Point(12, 92);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FirstNameTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstNameTextbox.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstNameTextbox.Location = new System.Drawing.Point(51, 37);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.PasswordChar = '\0';
            this.FirstNameTextbox.ReadOnly = true;
            this.FirstNameTextbox.Size = new System.Drawing.Size(226, 58);
            this.FirstNameTextbox.TabIndex = 7;
            this.FirstNameTextbox.Text = "gunaLineTextBox2";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 14);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First Name";
            // 
            // YearLevelComboBox
            // 
            this.YearLevelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YearLevelComboBox.BaseColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLevelComboBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLevelComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.YearLevelComboBox.ForeColor = System.Drawing.Color.Black;
            this.YearLevelComboBox.FormattingEnabled = true;
            this.YearLevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.YearLevelComboBox.Location = new System.Drawing.Point(752, 142);
            this.YearLevelComboBox.Name = "YearLevelComboBox";
            this.YearLevelComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.YearLevelComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.YearLevelComboBox.Size = new System.Drawing.Size(226, 31);
            this.YearLevelComboBox.TabIndex = 6;
            this.YearLevelComboBox.Visible = false;
            // 
            // DegreeProgramTextbox
            // 
            this.DegreeProgramTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DegreeProgramTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DegreeProgramTextbox.Enabled = false;
            this.DegreeProgramTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DegreeProgramTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeProgramTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DegreeProgramTextbox.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DegreeProgramTextbox.Location = new System.Drawing.Point(51, 200);
            this.DegreeProgramTextbox.Name = "DegreeProgramTextbox";
            this.DegreeProgramTextbox.PasswordChar = '\0';
            this.DegreeProgramTextbox.ReadOnly = true;
            this.DegreeProgramTextbox.Size = new System.Drawing.Size(226, 58);
            this.DegreeProgramTextbox.TabIndex = 4;
            this.DegreeProgramTextbox.Text = "gunaLineTextBox2";
            // 
            // YearLevelLabel
            // 
            this.YearLevelLabel.AutoSize = true;
            this.YearLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YearLevelLabel.Location = new System.Drawing.Point(713, 103);
            this.YearLevelLabel.Name = "YearLevelLabel";
            this.YearLevelLabel.Size = new System.Drawing.Size(75, 20);
            this.YearLevelLabel.TabIndex = 5;
            this.YearLevelLabel.Text = "Year Level";
            // 
            // DegreeProgramLabel
            // 
            this.DegreeProgramLabel.AutoSize = true;
            this.DegreeProgramLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DegreeProgramLabel.Location = new System.Drawing.Point(12, 177);
            this.DegreeProgramLabel.Name = "DegreeProgramLabel";
            this.DegreeProgramLabel.Size = new System.Drawing.Size(119, 20);
            this.DegreeProgramLabel.TabIndex = 4;
            this.DegreeProgramLabel.Text = "Degree Program";
            // 
            // ChangePictureButton
            // 
            this.ChangePictureButton.AnimationHoverSpeed = 0.07F;
            this.ChangePictureButton.AnimationSpeed = 0.03F;
            this.ChangePictureButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChangePictureButton.BorderColor = System.Drawing.Color.Black;
            this.ChangePictureButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangePictureButton.ForeColor = System.Drawing.Color.White;
            this.ChangePictureButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangePictureButton.Image")));
            this.ChangePictureButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangePictureButton.Location = new System.Drawing.Point(73, 256);
            this.ChangePictureButton.Name = "ChangePictureButton";
            this.ChangePictureButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChangePictureButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangePictureButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangePictureButton.OnHoverImage = null;
            this.ChangePictureButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChangePictureButton.Size = new System.Drawing.Size(160, 42);
            this.ChangePictureButton.TabIndex = 4;
            this.ChangePictureButton.Text = "Change Profile";
            this.ChangePictureButton.Visible = false;
            this.ChangePictureButton.Click += new System.EventHandler(this.ChangePictureButton_Click);
            // 
            // YearLevelTextbox
            // 
            this.YearLevelTextbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLevelTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearLevelTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.YearLevelTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevelTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YearLevelTextbox.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearLevelTextbox.Location = new System.Drawing.Point(752, 126);
            this.YearLevelTextbox.Name = "YearLevelTextbox";
            this.YearLevelTextbox.PasswordChar = '\0';
            this.YearLevelTextbox.ReadOnly = true;
            this.YearLevelTextbox.Size = new System.Drawing.Size(226, 58);
            this.YearLevelTextbox.TabIndex = 13;
            this.YearLevelTextbox.Text = "<YearLevel>";
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.AnimationHoverSpeed = 0.07F;
            this.CancelEditButton.AnimationSpeed = 0.03F;
            this.CancelEditButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CancelEditButton.BorderColor = System.Drawing.Color.Black;
            this.CancelEditButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CancelEditButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CancelEditButton.CheckedForeColor = System.Drawing.Color.White;
            this.CancelEditButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CancelEditButton.CheckedImage")));
            this.CancelEditButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CancelEditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelEditButton.ForeColor = System.Drawing.Color.White;
            this.CancelEditButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelEditButton.Image")));
            this.CancelEditButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelEditButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CancelEditButton.Location = new System.Drawing.Point(461, 243);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CancelEditButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelEditButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelEditButton.OnHoverImage = null;
            this.CancelEditButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CancelEditButton.OnPressedColor = System.Drawing.Color.Black;
            this.CancelEditButton.Size = new System.Drawing.Size(226, 42);
            this.CancelEditButton.TabIndex = 14;
            this.CancelEditButton.Text = "Cancel Edit ";
            this.CancelEditButton.Visible = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // ProfileContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "ProfileContent";
            this.Size = new System.Drawing.Size(1026, 675);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel HeaderPanel;
        private Guna.UI.WinForms.GunaCirclePictureBox ProfilePictureBox;
        private Guna.UI.WinForms.GunaPanel FooterPanel;
        private Guna.UI.WinForms.GunaLineTextBox CompleteNameLabel;
        private Guna.UI.WinForms.GunaAdvenceButton EditButton;
        private Guna.UI.WinForms.GunaLabel YearLevelLabel;
        private Guna.UI.WinForms.GunaLabel DegreeProgramLabel;
        private Guna.UI.WinForms.GunaComboBox YearLevelComboBox;
        private Guna.UI.WinForms.GunaLineTextBox DegreeProgramTextbox;
        private Guna.UI.WinForms.GunaLineTextBox LastNameTextbox;
        private Guna.UI.WinForms.GunaLabel LastNameLabel;
        private Guna.UI.WinForms.GunaLineTextBox FirstNameTextbox;
        private Guna.UI.WinForms.GunaLabel FirstNameLabel;
        private Guna.UI.WinForms.GunaLineTextBox EmailTextbox;
        private Guna.UI.WinForms.GunaLabel EmailLabel;
        private Guna.UI.WinForms.GunaAdvenceButton EditProfileButton;
        private Guna.UI.WinForms.GunaButton ChangePictureButton;
        private Guna.UI.WinForms.GunaLineTextBox YearLevelTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton CancelEditButton;
    }
}
