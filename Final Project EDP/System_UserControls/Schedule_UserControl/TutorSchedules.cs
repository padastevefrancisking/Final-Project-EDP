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
    public partial class TutorSchedules : UserControl
    {
        private Schedule s;
        private Schedules sch;
        public TutorSchedules(Schedule s, Schedules sch)
        {
            InitializeComponent();
            this.s = s;
            this.sch = sch; 

            DatabaseCon dc = new DatabaseCon();
            this.SubjectsLabel.Text = dc.getTagName(s.TutoredSubject) + " by " + s.Tutor;
            this.DescriptionLabel.Text = s.ScheduleDescription + " (Tutor)";
            this.LocationLabel.Text = s.ScheduleLocation;
            this.TimeLabel.Text = s.ScheduleTimeStart.ToString("hh:mm:tt") + " - " + s.ScheduleTimeEnd.ToString("hh:mm:tt");
            this.TuteeCountLabel.Text = s.Tutees.Count.ToString();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ScheduleDetails sd = new ScheduleDetails(this.s);
            sd.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this request?", "Confirmation", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                DatabaseCon dc = new DatabaseCon();
                dc.CancelSchedule(this.s);
            }

            sch.UpdateFlowPanel(1);
        }
    }
}
