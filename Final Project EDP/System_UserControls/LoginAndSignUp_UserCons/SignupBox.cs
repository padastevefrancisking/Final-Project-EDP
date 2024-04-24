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
using Final_Project_EDP.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using System.IO;

namespace Final_Project_EDP.System_UserControls
{
    public partial class SignupBox : UserControl
    {
        public PreMainForm Mm { get; private set; }
        private int otp;
        private byte[] imagePath;
        public SignupBox(PreMainForm m)
        {
            InitializeComponent();
            this.Mm = m;
            this.OTPTextbox.Enabled = false;
            this.ProfilePictureBox.ImageLocation = "LoginBackground.jpg";
        }

        private void gunaGradiantButton1_Click(object sender, EventArgs e)
        {
            string fPass = PasswordTextbox.Text, lPass = RetypePasswordTextbox.Text;
            string fName = FirstNameTextbox.Text, lName = LastNameTextbox.Text;
            string email = EmailAddressTextbox.Text;
            string ot = this.OTPTextbox.Text;

            int yearLevel;
            switch (YearLevelComboBox.SelectedItem.ToString())
            {
                case "1":
                    yearLevel = 1;
                    break;
                case "2":
                    yearLevel = 2;
                    break;
                case "3":
                    yearLevel = 3;
                    break;
                case "4":
                    yearLevel = 4;
                    break;
                default:
                    yearLevel = 0;
                    break;
            }

            if (fPass == string.Empty || fName == string.Empty || email == string.Empty || this.otp.ToString() == string.Empty || yearLevel == 0)
            {
                MessageBox.Show("Complete all fields.");
                return;
            }

            if (fPass != lPass)
            {
                MessageBox.Show("Passwords don't match. Retype again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.otp.ToString() != ot)
            {
                MessageBox.Show("OTP doesn't match. Retype again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account acc = new Account(email, fName, lName, this.imagePath, yearLevel, fPass);

            DatabaseCon dc = new DatabaseCon();
            if (dc.InsertAccount(acc))
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
            if (dc.VerifyEmail(this.EmailAddressTextbox.Text) && dc.IsUniqueEmail(this.EmailAddressTextbox.Text))
            {
                this.otp = this.Mm.SendOtpToGmail(this.EmailAddressTextbox.Text);
                this.OTPTextbox.Enabled = true;
            }
            else
            {
                MessageBox.Show("This email is already used. Try another.");
            }
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*jpeg;*png";
                ofd.Title = "Select Profile Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the selected image file into a byte array
                        byte[] imageData = File.ReadAllBytes(ofd.FileName);

                        // Validate image format (optional)
                        if (!ValidateImageFormat(imageData))
                        {
                            MessageBox.Show("Invalid image format. Please select a JPG, JPEG, or PNG file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Convert byte array to Image object for display
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            ProfilePictureBox.Image = Image.FromStream(ms);
                        }

                        // Optionally store the byte array for future use
                        this.imagePath = imageData;  // Or use another serialization method
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool ValidateImageFormat(byte[] imageData)
        {
            if (imageData.Length < 10)
            {
                return false; // File size too small (basic check)
            }

            // Check for common image format headers (more robust validation)
            if (imageData[0] == 0xFF && imageData[1] == 0xD8 && imageData[2] == 0xFF)  // JPEG
            {
                return true;
            }
            else if (imageData[0] == 0x89 && imageData[1] == 'P' && imageData[2] == 'N' && imageData[3] == 'G') // PNG
            {
                return true;
            }
            else
            {
                return false; // Not a recognized image format
            }
        }
    }
}
