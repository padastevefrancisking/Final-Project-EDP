using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Final_Project_EDP.System_Forms;

namespace Final_Project_EDP.System_UserControls
{
    public partial class SignupBox : UserControl
    {
        public PreMainForm Mm { get; private set; }
        private int otp;
        public SignupBox(PreMainForm m)
        {
            InitializeComponent();
            this.Mm = m;
            this.OTPTextbox.Enabled = false;
        }

        private void gunaGradiantButton1_Click(object sender, EventArgs e)
        {
            string fPass = PasswordTextbox.Text, lPass = RetypePasswordTextbox.Text;
            string fName = FirstNameTextbox.Text, lName = LastNameTextbox.Text;
            string email = EmailAddressTextbox.Text, username = UsernameTextbox.Text;
            DateTime bday = BirthdatePicker.Value;
            Gender gender;
            string ot = this.OTPTextbox.Text;
            
            switch(GenderComboBox.SelectedItem.ToString())
            {
                case "Male":
                    gender = Gender.Male;
                    break;
                case "Female":
                    gender = Gender.Female;
                    break;
                case "Others":
                    gender = Gender.Others;
                    break;
                case "Prefer not to say":
                    gender = Gender.PreferNotToSay;
                    break;
                default:
                    gender = Gender.Unassigned;
                    break;
            }

            if(bday == null || fPass == string.Empty || fName == string.Empty || email == string.Empty || gender == Gender.Unassigned || this.otp.ToString() == string.Empty) 
            {
                MessageBox.Show("Complete all fields.");
                return;
            }

            if (fPass != lPass) 
            {
                MessageBox.Show("Passwords don't match. Retype again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.otp.ToString() != ot)
            {
                MessageBox.Show("OTP doesn't match. Retype again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account acc = new Account(fName, lName, gender, bday, username, email, fPass);

            DatabaseCon dc = new DatabaseCon();
            if(dc.InsertAccount(acc))
            {
                MessageBox.Show("Successful!");
            }
            
            MainForm form = new MainForm(dc.GetAccount(email));
            form.BringToFront();
            form.Show();
            Mm.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            Mm.LoginPanel.Controls.Clear();
            Mm.LoginPanel.Controls.Add(new LoginBox(this.Mm));
            this.Hide();
        }

        private void SendOTPButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            if(dc.VerifyEmail(this.EmailAddressTextbox.Text))
            {
                this.otp = this.Mm.SendOtpToGmail(this.EmailAddressTextbox.Text);
            }
        }
    }
}
