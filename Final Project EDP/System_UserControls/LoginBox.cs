using Final_Project_EDP.System_Forms;
using Final_Project_EDP.System_UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP
{
    public partial class LoginBox : UserControl
    {
        public MainMenu mm { get; set; }
        public LoginBox(MainMenu m)
        {
            InitializeComponent();
            this.mm = m;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            string emailAddress = EmailAddressTextbox.Text, password = PasswordTextbox.Text;

            if (emailAddress == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Complete all fields");
                return;
            }
            if (dc.verifyLoginInformation(emailAddress, password))
            {
                MainForm form = new MainForm(dc.GetAccount(emailAddress));
                form.BringToFront();
                form.Show();
                mm.Hide();
            }
        }

        private void SignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mm.sb.BringToFront();
        }
    }
}
