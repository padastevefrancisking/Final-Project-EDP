namespace Final_Project_EDP.System_UserControls
{
    partial class Requests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.RequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectTutoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRequestButton = new Guna.UI.WinForms.GunaButton();
            this.RequestListButton = new Guna.UI.WinForms.GunaButton();
            this.PendingRequestsButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 21;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestID,
            this.SubjectTutoring,
            this.Location,
            this.TutorSchedule,
            this.TutorStart,
            this.TutorEnd});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(17, 74);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(986, 469);
            this.gunaDataGridView1.TabIndex = 4;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RequestID
            // 
            this.RequestID.HeaderText = "RequestID";
            this.RequestID.Name = "RequestID";
            this.RequestID.ReadOnly = true;
            // 
            // SubjectTutoring
            // 
            this.SubjectTutoring.HeaderText = "Subject";
            this.SubjectTutoring.Name = "SubjectTutoring";
            this.SubjectTutoring.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // TutorSchedule
            // 
            this.TutorSchedule.HeaderText = "Schedule";
            this.TutorSchedule.Name = "TutorSchedule";
            this.TutorSchedule.ReadOnly = true;
            // 
            // TutorStart
            // 
            this.TutorStart.HeaderText = "Starting Time";
            this.TutorStart.Name = "TutorStart";
            this.TutorStart.ReadOnly = true;
            // 
            // TutorEnd
            // 
            this.TutorEnd.HeaderText = "Ending Time";
            this.TutorEnd.Name = "TutorEnd";
            this.TutorEnd.ReadOnly = true;
            // 
            // AddRequestButton
            // 
            this.AddRequestButton.AnimationHoverSpeed = 0.07F;
            this.AddRequestButton.AnimationSpeed = 0.03F;
            this.AddRequestButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddRequestButton.BorderColor = System.Drawing.Color.Black;
            this.AddRequestButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddRequestButton.ForeColor = System.Drawing.Color.White;
            this.AddRequestButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRequestButton.Image")));
            this.AddRequestButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddRequestButton.Location = new System.Drawing.Point(843, 578);
            this.AddRequestButton.Name = "AddRequestButton";
            this.AddRequestButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddRequestButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddRequestButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddRequestButton.OnHoverImage = null;
            this.AddRequestButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddRequestButton.Size = new System.Drawing.Size(160, 42);
            this.AddRequestButton.TabIndex = 0;
            this.AddRequestButton.Text = "Add Request";
            this.AddRequestButton.Click += new System.EventHandler(this.AddRequestButton_Click);
            // 
            // RequestListButton
            // 
            this.RequestListButton.AnimationHoverSpeed = 0.07F;
            this.RequestListButton.AnimationSpeed = 0.03F;
            this.RequestListButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RequestListButton.BorderColor = System.Drawing.Color.Black;
            this.RequestListButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RequestListButton.ForeColor = System.Drawing.Color.White;
            this.RequestListButton.Image = ((System.Drawing.Image)(resources.GetObject("RequestListButton.Image")));
            this.RequestListButton.ImageSize = new System.Drawing.Size(20, 20);
            this.RequestListButton.Location = new System.Drawing.Point(510, 0);
            this.RequestListButton.Name = "RequestListButton";
            this.RequestListButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RequestListButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RequestListButton.OnHoverForeColor = System.Drawing.Color.White;
            this.RequestListButton.OnHoverImage = null;
            this.RequestListButton.OnPressedColor = System.Drawing.Color.Black;
            this.RequestListButton.Size = new System.Drawing.Size(510, 58);
            this.RequestListButton.TabIndex = 2;
            this.RequestListButton.Text = "Request List";
            this.RequestListButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PendingRequestsButton
            // 
            this.PendingRequestsButton.AnimationHoverSpeed = 0.07F;
            this.PendingRequestsButton.AnimationSpeed = 0.03F;
            this.PendingRequestsButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PendingRequestsButton.BorderColor = System.Drawing.Color.Black;
            this.PendingRequestsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PendingRequestsButton.ForeColor = System.Drawing.Color.White;
            this.PendingRequestsButton.Image = ((System.Drawing.Image)(resources.GetObject("PendingRequestsButton.Image")));
            this.PendingRequestsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PendingRequestsButton.Location = new System.Drawing.Point(0, 0);
            this.PendingRequestsButton.Name = "PendingRequestsButton";
            this.PendingRequestsButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PendingRequestsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PendingRequestsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.PendingRequestsButton.OnHoverImage = null;
            this.PendingRequestsButton.OnPressedColor = System.Drawing.Color.Black;
            this.PendingRequestsButton.Size = new System.Drawing.Size(510, 58);
            this.PendingRequestsButton.TabIndex = 0;
            this.PendingRequestsButton.Text = "Pending Requests";
            this.PendingRequestsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Requests
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.AddRequestButton);
            this.Controls.Add(this.RequestListButton);
            this.Controls.Add(this.PendingRequestsButton);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(1020, 634);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton PendingRequestsButton;
        private Guna.UI.WinForms.GunaButton RequestListButton;
        private Guna.UI.WinForms.GunaButton AddRequestButton;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectTutoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorEnd;
    }
}
