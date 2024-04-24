using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using Final_Project_EDP.System_Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace Final_Project_EDP.System_UserControls
{
    public partial class RequestFillup : UserControl
    {
        private Form f;
        private Requests req;
        public List<Account> accs { get; set; }
        private int identifier;
        public RequestFillup(Form f, Requests req)
        {
            InitializeComponent();
            this.f = f;
            this.req = req;
            this.accs = new List<Account>();
            accs.Add(this.req.mf.A);
            this.identifier = 0;


            this.SoloRequestCheckBox.Checked = true;
            this.refreshPanel();

            this.SubjectTagComboBox.Items.Clear();

            DatabaseCon dc = new DatabaseCon();
            List<string> tags = dc.GetTags();

            foreach (string tag in tags)
                this.SubjectTagComboBox.Items.Add(tag);

            this.MakeRequestButton.Text = "Make Request";
            this.TutorScheduleDateTimePicker.Value = DateTime.Now;
            this.TutorScheduleDateTimePicker.MinDate = DateTime.Now;
            this.TutorScheduleDateTimePicker.MaxDate = DateTime.Now.AddYears(1);
        }

        public RequestFillup(Form f, Requests req, Request r)
        {
            InitializeComponent();
            this.f = f;
            this.req = req;
            this.accs = r.Tutees;
            this.identifier = r.RequestID;

            this.SubjectTagComboBox.Items.Clear();
            DatabaseCon dc = new DatabaseCon();
            List<string> tags = dc.GetTags();

            foreach (string s in tags)
                this.SubjectTagComboBox.Items.Add(s);

            this.refreshPanel();

            this.SubjectTagComboBox.SelectedIndex = r.TutoredSubjects - 1;
            this.RequestLocationTextbox.Text = r.RequestLocation;
            this.TutorScheduleDateTimePicker.Value = r.RequestDay;
            this.StartTimePicker.Value = r.RequestTimeStart;
            this.EndTimePicker.Value = r.RequestTimeEnd;
            this.RemarksTextbox.Text = r.Remarks;
            this.MakeRequestButton.Text = "Edit Request";
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DateTime threeDaysAfter = DateTime.Now.AddDays(3).AddHours(-DateTime.Now.Hour).AddMinutes(-DateTime.Now.Minute).AddSeconds(-DateTime.Now.Second).AddMilliseconds(-DateTime.Now.Millisecond);
            TimeSpan tutorSpan = EndTimePicker.Value - StartTimePicker.Value;
          
            //ComboBox and Tutoring Location is not empty
            //Request Made 3 days before the tutoring
            //TimeStart and Time End does not conflict and its duration must be more than an hour
            if (SubjectTagComboBox.SelectedItem != null && RequestLocationTextbox.Text != string.Empty && this.RemarksTextbox.Text != string.Empty && TutorScheduleDateTimePicker.Value >= threeDaysAfter && Math.Abs(StartTimePicker.Value.Subtract(EndTimePicker.Value).TotalMinutes) >= 60 && tutorSpan.TotalMinutes >= 60) 
            {
                DatabaseCon dc = new DatabaseCon();

                List<string> tags = dc.GetTags();
                int t = 0;
                foreach (string tag in tags)
                {
                    if(SubjectTagComboBox.SelectedItem.ToString() == tag)
                    {
                        t = tags.IndexOf(tag) + 1;
                        break;
                    }
                }

                Request r = new Request(this.req.mf.A, this.RequestLocationTextbox.Text, this.TutorScheduleDateTimePicker.Value, this.StartTimePicker.Value, this.EndTimePicker.Value, t, accs, this.RemarksTextbox.Text);

                if(this.identifier > 0)
                {
                    dc.UpdateRequest(this.identifier, r);
                    MessageBox.Show("Edit Successful!");
                }
                else
                {
                    dc.InsertRequest(r);
                    MessageBox.Show("Request Successful!");
                }
                
                dc.UpdateRequestTable(req.RequestTable, this.req.mode, this.req.mf.A.EmailAddress, 1);
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
            
        public void refreshPanel()
        {
            this.TuteesLayoutPanel.Controls.Clear();

            GunaButton gb = new GunaButton();
            gb.Radius = 10;
            gb.MinimumSize = new Size(115, 45);
            gb.Text = accs[0].EmailAddress;
            gb.Enabled = false;
            gb.Width = Math.Max(TextRenderer.MeasureText(gb.Text, gb.Font).Width, gb.MinimumSize.Width);
            this.TuteesLayoutPanel.Controls.Add(gb);

            for (int i = 1; i < accs.Count; i++)
            {
                gb = new GunaButton();
                gb.Radius = 10;
                gb.MinimumSize = new Size(115, 45);
                gb.Text = accs[i].EmailAddress;
                gb.Click += Gb_Click;
                gb.Width = Math.Max(TextRenderer.MeasureText(gb.Text, gb.Font).Width, gb.MinimumSize.Width);
                this.TuteesLayoutPanel.Controls.Add(gb);
            }
        }

        private void Gb_Click(object sender, EventArgs e)
        {
            GunaButton gb = sender as GunaButton;

            DatabaseCon dc = new DatabaseCon();
            Account temp = dc.GetAccount(gb.Text);

            this.accs.Remove(temp);
            this.TuteesLayoutPanel.Controls.Remove((GunaButton)sender);
        }

        private void SearchTuteeTextbox_TextChanged(object sender, EventArgs e)
        {
            this.SearchboxResultPanel.Controls.Clear();
            this.UpdateSearchResult();
        }
        public void UpdateSearchResult()
        {
            DatabaseCon dc = new DatabaseCon();
            List<Account> tuts = dc.SearchAccount(this.req.mf.A, this.SearchTuteeTextbox.Text);

            if (tuts == null)
            {
                this.SearchboxResultPanel.Visible = false;
                return;
            }

            bool flag = true;
            foreach (Account a in tuts)
            {
                if (a.EmailAddress != this.req.mf.A.EmailAddress && !accs.Contains(a))
                {
                    this.SearchboxResultPanel.Visible = true;
                    TuteeSearchResult tsr = new TuteeSearchResult(a, this);
                    tsr.MinimumSize = new Size(this.SearchboxResultPanel.Width, 20);

                    this.SearchboxResultPanel.Controls.Add((tsr));
                    flag = false;
                }
            }

            if(flag)
                this.SearchboxResultPanel.Visible = false;
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            string r = "";
            foreach(Account a in this.accs)
            {
                r += a.ToString() + "\n";
            }

            MessageBox.Show(r);
        }
    }
}
