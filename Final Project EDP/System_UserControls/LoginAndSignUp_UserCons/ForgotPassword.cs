using Final_Project_EDP.System_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls.LoginAndSignUp_UserCons
{
    public partial class ForgotPassword : UserControl
    {
        private PreMainForm mm;
        private int otp;
        public ForgotPassword(PreMainForm mm)
        {
            InitializeComponent();
            this.mm = mm;
        }

        private void SendOTPButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            if(dc.VerifyEmail(this.ForgotPasswordEmailAddressTextbox.Text)) 
                this.otp = this.mm.SendOtpToGmail(this.ForgotPasswordEmailAddressTextbox.Text);
        }

        private void ForgotPasswordLoginButton_Click(object sender, EventArgs e)
        {
            DatabaseCon dc = new DatabaseCon();
            if (dc.VerifyEmail(this.ForgotPasswordEmailAddressTextbox.Text) && this.OTPTextBox.Text == this.otp.ToString())
            {
                MainForm form = new MainForm(dc.GetAccount(this.ForgotPasswordEmailAddressTextbox.Text));
                form.BringToFront();
                form.Show();
                mm.Hide();
            }
            else if (this.ForgotPasswordEmailAddressTextbox.Text == string.Empty || this.OTPTextBox.Text == string.Empty)
                MessageBox.Show("Fill up all fields first.");
            else if (!dc.VerifyEmail(this.ForgotPasswordEmailAddressTextbox.Text))
                MessageBox.Show("Invalid Email.");
            else if (this.otp.ToString() != this.OTPTextBox.Text)
                MessageBox.Show("Incorrect OTP");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            mm.LoginPanel.Controls.Clear();
            mm.LoginPanel.Controls.Add(new LoginBox(this.mm));
            this.Hide();
        }
    }
}
