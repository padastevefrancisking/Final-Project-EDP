using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Forms.Subforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls.Schedule_UserControl
{
    public partial class TuteeSchedules : UserControl
    {
        private Schedule s;
        private Schedules sch;
        public TuteeSchedules(Schedule s, Schedules sched)
        {
            InitializeComponent();
            this.s = s;
            this.sch = sched;

            DatabaseCon dc = new DatabaseCon();
            this.SubjectsLabel.Text = dc.getTagName(s.TutoredSubject) + " by " + s.Tutor;
            this.DescriptionLabel.Text = s.ScheduleDescription + " (Tutee)";
            this.LocationLabel.Text = s.ScheduleLocation;
            this.TimeLabel.Text = s.ScheduleTimeStart.ToString("hh:mm:tt") + " - " + s.ScheduleTimeEnd.ToString("hh:mm:tt");
            this.TuteeCountLabel.Text = s.Tutees.Count.ToString();

            if(s.Tutees.Contains(sch.mf.A))
            {
                this.AcceptButton.Visible = false;
                this.DenyButton.Visible = false;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            dc.AcceptSchedule(this.s, this.sch.mf.A);

            this.sch.UpdateFlowPanel(0);
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            dc.DenySchedule(this.s, this.sch.mf.A);

            this.sch.UpdateFlowPanel(0);
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ScheduleDetails sd = new ScheduleDetails(this.s);
            sd.ShowDialog();
        }
    }
}
