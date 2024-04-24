using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_UserControls;
using MySql.Data;
using System.Net.Mail;
using System.Net;
using Final_Project_EDP.System_UserControls.LoginAndSignUp_UserCons;


namespace Final_Project_EDP
{
    public partial class PreMainForm : Form
    { 
        public PreMainForm()
        {
            InitializeComponent();
            LoginPanel.Controls.Add(new LoginBox(this));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int SendOtpToGmail(string recipient)
        {

            int otp = new Random().Next(100000, 1000000);

                string sender = "studyverseapp@gmail.com";
                string password = "vnyw amod ufnk nwym";
                string smtpServer = "smtp.gmail.com";
                int port = 587;

            var message = new MailMessage(sender, recipient);
            message.Subject = "Your One-Time Password (OTP)";
            message.Body = $"Your OTP is: {otp}";
            message.IsBodyHtml = false;

            using (var smtpClient = new SmtpClient(smtpServer, port))
            {
                smtpClient.EnableSsl = true; 
                smtpClient.Credentials = new NetworkCredential(sender, password);
                smtpClient.Send(message);
            }

            return otp;
        }
    }
}
