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

namespace Final_Project_EDP.System_UserControls
{
    public partial class SignupBox : UserControl
    {
        public SignupBox()
        {
            InitializeComponent();
        }

        private void gunaGradiantButton1_Click(object sender, EventArgs e)
        {
            string fPass = PasswordTextbox.Text, lPass = RetypePasswordTextbox.Text;
            string fName = FirstNameTextbox.Text, lName = LastNameTextbox.Text;
            string email = EmailAddressTextbox.Text, username = UsernameTextbox.Text;
            DateTime bday = BirthdatePicker.Value;
            Gender gender;
            
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

            if(bday == null || fPass == string.Empty || fName == string.Empty || email == string.Empty || gender == Gender.Unassigned) 
            {
                MessageBox.Show("Complete all fields.");
                return;
            }

            if (fPass != lPass) 
            {
                MessageBox.Show("Passwords don't match. Retype again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(fName + lName);
                return;
            }
            Account acc = new Account(fName, lName, gender, bday, username, email, fPass);

            DatabaseCon dc = new DatabaseCon();
            if(dc.InsertAccount(acc))
            {
                MessageBox.Show("Successful!");
            }
            Application.Exit();
        }
    }
}
