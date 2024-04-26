using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_UserControls;
using Final_Project_EDP.System_UserControls.Schedule_UserControl;

namespace Final_Project_EDP.System_Forms.Subforms
{
    public partial class ScheduleDetails : Form
    {
        private Schedule s;
        public ScheduleDetails(Schedule s)
        {
            InitializeComponent();
            this.s = s;

            DatabaseCon dc = new DatabaseCon();
            this.SubjectLabel.Text = dc.getTagName(s.TutoredSubject) + " Tutoring";
            this.TutorLabel.Text = " By: " + s.Tutor;
            this.DescriptionLabel.Text = s.ScheduleDescription;
            this.LocationLabel.Text = s.ScheduleLocation;
            this.ScheduleDayLabel.Text = s.ScheduleDay.ToString("dddd, dd MMM");
            this.TimeLabel.Text = s.ScheduleTimeStart.ToString("hh:mm tt") + " - " + s.ScheduleTimeEnd.ToString("hh:mm tt");
            this.TutorRemarksLabel.Text = s.Remarks;
            this.ScheduleStatusLabel.Text = s.ScheduleStatus.ToString();

            this.TuteeLabel.Text = "Tutees: " + s.Tutees.Count.ToString();
            this.updateScheduleTuteeList();
        }

        private void ExitDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateScheduleTuteeList()
        {
            foreach(Account t in s.Tutees)
                this.TuteeFlowLayoutPanel.Controls.Add(new ScheduleStudents(t));
        }
    }
}
