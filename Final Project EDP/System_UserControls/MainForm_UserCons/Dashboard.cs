using Final_Project_EDP.System_Classes;
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
    public partial class Dashboard : UserControl
    {
        public MainForm mf;
        public Dashboard(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.Dock = DockStyle.Fill;

            DatabaseCon dc = new DatabaseCon();
            this.PendingAmountPanel.Text = dc.GetNumberOfRequests(this.mf.A).ToString();
        }
    }
}
