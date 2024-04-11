using Guna.UI.WinForms;
using System.Windows.Forms.VisualStyles;

namespace Final_Project_EDP.System_Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabsPanel = new Guna.UI.WinForms.GunaPanel();
            this.SubTabsPanel = new Guna.UI.WinForms.GunaPanel();
            this.Exit = new Guna.UI.WinForms.GunaButton();
            this.ContentPanel = new Guna.UI.WinForms.GunaPanel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SubTabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsPanel
            // 
            this.TabsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabsPanel.Location = new System.Drawing.Point(0, 0);
            this.TabsPanel.Name = "TabsPanel";
            this.TabsPanel.Size = new System.Drawing.Size(250, 632);
            this.TabsPanel.TabIndex = 0;
            // 
            // SubTabsPanel
            // 
            this.SubTabsPanel.AutoSize = true;
            this.SubTabsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SubTabsPanel.Controls.Add(this.Exit);
            this.SubTabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubTabsPanel.Location = new System.Drawing.Point(250, 0);
            this.SubTabsPanel.Name = "SubTabsPanel";
            this.SubTabsPanel.Size = new System.Drawing.Size(984, 49);
            this.SubTabsPanel.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.AnimationHoverSpeed = 0.07F;
            this.Exit.AnimationSpeed = 0.03F;
            this.Exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Exit.BorderColor = System.Drawing.Color.Black;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit.Location = new System.Drawing.Point(931, 4);
            this.Exit.Name = "Exit";
            this.Exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit.OnHoverForeColor = System.Drawing.Color.White;
            this.Exit.OnHoverImage = null;
            this.Exit.OnPressedColor = System.Drawing.Color.Black;
            this.Exit.Size = new System.Drawing.Size(41, 42);
            this.Exit.TabIndex = 0;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoSize = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(250, 49);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(984, 583);
            this.ContentPanel.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 632);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SubTabsPanel);
            this.Controls.Add(this.TabsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SubTabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel TabsPanel;
        private Guna.UI.WinForms.GunaPanel SubTabsPanel;
        private Guna.UI.WinForms.GunaPanel ContentPanel;
        private Guna.UI.WinForms.GunaButton Exit;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;

        public GunaPanel getContentPanel() { return this.ContentPanel; }
    }
}