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
using Final_Project_EDP.System_UserControls;
using Final_Project_EDP.System_UserControls.Schedule_UserControl;

namespace Final_Project_EDP.System_UserControls
{
    public partial class Schedules : UserControl
    {
        public MainForm mf { get; private set; }
        public Schedules(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.UpdateFlowPanel(1);
        }

        private void TutoringScheduleButton_Click(object sender, EventArgs e)
        {
            this.UpdateFlowPanel(1);
        }

        private void TuteeScheduleButton_Click(object sender, EventArgs e)
        {
            this.UpdateFlowPanel(0);
        }

        public void UpdateFlowPanel(int mode)
        {
            if (mode == 0)
            {
                DatabaseCon dc = new DatabaseCon();
                List<Schedule> scheds = dc.GetTuteeSchedule(this.mf.A);

                this.SchedulesFlowLayoutPanel.Controls.Clear();
                foreach (Schedule schedule in scheds)
                {
                    TuteeSchedules ts = new TuteeSchedules(schedule, this);
                    this.SchedulesFlowLayoutPanel.Controls.Add(ts);
                }
            }
            else if (mode == 1)
            {
                DatabaseCon dc = new DatabaseCon();
                List<Schedule> scheds = dc.GetTutorSchedule(this.mf.A);

                this.SchedulesFlowLayoutPanel.Controls.Clear();
                foreach (Schedule schedule in scheds)
                {
                    TutorSchedules ts = new TutorSchedules(schedule, this);
                    this.SchedulesFlowLayoutPanel.Controls.Add(ts);
                }
            }
        }
    }
}
