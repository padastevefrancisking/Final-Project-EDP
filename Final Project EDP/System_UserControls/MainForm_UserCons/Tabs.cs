using Final_Project_EDP.System_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls
{
    public partial class Tabs : UserControl
    {
        MainForm mf;
        public Tabs(MainForm m)
        {
            InitializeComponent();
            this.mf = m;
            this.TabsHeaderLabel.Text = "Welcome, " + mf.A.FirstName + " " + mf.A.LastName;

            using (MemoryStream ms = new MemoryStream(this.mf.A.ImagePath)) 
            {  
                Image image = Image.FromStream(ms);
                this.LogoPictureBox.Image = image;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) {
                PreMainForm mm = new PreMainForm();
                mm.BringToFront();
                mm.Show();
                this.mf.Hide();
            }
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            mf.getContentPanel().Controls.Clear();
            mf.getContentPanel().Controls.Add(new Dashboard(mf));
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            mf.getContentPanel().Controls.Clear();
            mf.getContentPanel().Controls.Add(new Requests(mf));
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            mf.getContentPanel().Controls.Clear();
            mf.getContentPanel().Controls.Add(new Schedules(mf));
        }
    }
}
