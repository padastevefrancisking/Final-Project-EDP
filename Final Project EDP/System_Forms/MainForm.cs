using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_UserControls;

namespace Final_Project_EDP.System_Forms
{
    public partial class MainForm : Form
    {
        public Account A {  get; private set; }
        public int PendingReqs { get; set; }

        public MainForm(Account a)
        {
            InitializeComponent();
            this.A = a;

            TabsPanel.Controls.Add(new Tabs(this));
            ContentPanel.Controls.Add(new Dashboard(this));
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
