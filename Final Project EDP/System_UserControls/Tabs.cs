using Final_Project_EDP.System_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.TabsHeaderLabel.Text = "Welcome, " + mf.a.getFirstName() + " " + mf.a.getLastName();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) {
                MainMenu mm = new MainMenu();
                mm.BringToFront();
                mm.Show();
                this.Hide();
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
    }
}
