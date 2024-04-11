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
using Final_Project_EDP.System_Enums;
using Final_Project_EDP.System_Forms;

namespace Final_Project_EDP.System_UserControls
{
    public partial class RequestFillup : UserControl
    {
        private Form f;
        private Requests req;
        public RequestFillup(Form f, Requests req)
        {
            InitializeComponent();
            this.f = f;
            this.req = req;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DateTime threeDaysAfter = DateTime.Now.AddDays(3).AddHours(-DateTime.Now.Hour).AddMinutes(-DateTime.Now.Minute).AddSeconds(-DateTime.Now.Second).AddMilliseconds(-DateTime.Now.Millisecond);
            TimeSpan tutorSpan = EndTimePicker.Value - StartTimePicker.Value;

            MessageBox.Show(threeDaysAfter.ToString());
            MessageBox.Show((SubjectTagComboBox.SelectedItem != null).ToString() + "\n" + (RequestLocationTextbox.Text != string.Empty).ToString() + "\n" + (TutorScheduleDateTimePicker.Value >= threeDaysAfter).ToString() + "\n" + (Math.Abs(StartTimePicker.Value.Subtract(EndTimePicker.Value).TotalMinutes) >= 60).ToString() + "\n" + (tutorSpan.TotalMinutes >= 60).ToString() + "\n");
          
            //ComboBox and Tutoring Location is not empty
            //Request Made 3 days before the tutoring
            //TimeStart and Time End does not conflict and its duration must be more than an hour
            if (SubjectTagComboBox.SelectedItem != null && RequestLocationTextbox.Text != string.Empty && TutorScheduleDateTimePicker.Value >= threeDaysAfter && Math.Abs(StartTimePicker.Value.Subtract(EndTimePicker.Value).TotalMinutes) >= 60 && tutorSpan.TotalMinutes >= 60) 
            {
                Tags t;
                
                switch(SubjectTagComboBox.SelectedItem.ToString())
                {
                    case "Mathematics":
                        t = Tags.Mathematics; break;
                    case "Computer Science":
                        t = Tags.ComputerScience; break;
                    case "Calculus":
                        t = Tags.Calculus; break;
                    default:
                        t = Tags.Physics; break;
                }

                List<Account> tuts = new List<Account>();
                tuts.Add(req.mf.a);
                Request r = new Request(RequestLocationTextbox.Text, TutorScheduleDateTimePicker.Value, StartTimePicker.Value, EndTimePicker.Value, t, tuts);

                DatabaseCon dc = new DatabaseCon();
                dc.InsertRequest(r);
                MessageBox.Show("Request Successful!");
                f.Hide();
            }

            else
            {
                MessageBox.Show("Fill up all fields");
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            f.Hide();
        }
    }
}
