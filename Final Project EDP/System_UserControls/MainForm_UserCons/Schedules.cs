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
using Final_Project_EDP.System_Classes;

namespace Final_Project_EDP.System_UserControls
{
    public partial class Schedules : UserControl
    {
        private MainForm mf;
        public Schedules(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void TutoringScheduleButton_Click(object sender, EventArgs e)
        {
        }

        private void TuteeScheduleButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            List<Schedule> scheds = dc.GetTuteeSchedule(this.mf.A);

            foreach (Schedule s in scheds)
            {
                string m = s.ToString();
                foreach(Account a in s.Tutees)
                {
                    m += "\n" + a.ToString();
                }

                MessageBox.Show(m);
            }
        }
    }
}
