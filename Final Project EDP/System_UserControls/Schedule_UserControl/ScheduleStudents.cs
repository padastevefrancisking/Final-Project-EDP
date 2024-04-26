using Final_Project_EDP.System_Classes;
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
    public partial class ScheduleStudents : UserControl
    {
        private Account a;
        public ScheduleStudents(Account a)
        {
            InitializeComponent();
            this.a = a;

            this.CompleteNameLabel.Text = a.ToString();
            this.DegreeAndYearLabel.Text = a.DegreeProgram + " - " + a.YearLevel.ToString();
        }
    }
}
