using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls.Profile_UserCons
{
    public partial class ProfileContent : UserControl
    {
        private MainForm mf;
        private byte[] imagePath;
        public ProfileContent(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.refreshProfile();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.FirstNameTextbox.ReadOnly = this.LastNameTextbox.ReadOnly = this.YearLevelTextbox.Visible = this.YearLevelTextbox.ReadOnly = this.EditButton.Visible = false;
            this.EditProfileButton.Visible = this.ChangePictureButton.Visible = this.YearLevelComboBox.Visible = this.CancelEditButton.Visible = true;
        }

        private void ChangePictureButton_Click(object sender, EventArgs e)
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

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            if(this.ProfilePictureBox.Image != null && this.LastNameTextbox.Text != string.Empty && this.FirstNameTextbox.Text != string.Empty ) 
            {
                Account a = new Account(this.EmailTextbox.Text, this.FirstNameTextbox.Text, this.LastNameTextbox.Text, this.imagePath, this.YearLevelComboBox.SelectedIndex + 1, this.mf.A.UserPassword);
                
                DatabaseCon dc = new DatabaseCon();
                dc.EditAccount(this.mf.A.EmailAddress, a);
                this.refreshProfile();
            }
        }

        private void refreshProfile()
        {
            this.imagePath = this.mf.A.ImagePath;

            using (MemoryStream ms = new MemoryStream(this.mf.A.ImagePath))
            {
                Image image = Image.FromStream(ms);
                this.ProfilePictureBox.Image = image;
            }

            this.CompleteNameLabel.Text = this.mf.A.ToString();
            this.FirstNameTextbox.Text = this.mf.A.FirstName;
            this.LastNameTextbox.Text = this.mf.A.LastName;
            this.DegreeProgramTextbox.Text = this.mf.A.DegreeProgram;

            this.YearLevelTextbox.Text = this.mf.A.YearLevel.ToString();
            this.EmailTextbox.Text = this.mf.A.EmailAddress;


            this.FirstNameTextbox.ReadOnly = this.LastNameTextbox.ReadOnly = this.YearLevelTextbox.Visible = this.YearLevelTextbox.ReadOnly = true;
            this.EditProfileButton.Visible = this.ChangePictureButton.Visible = this.YearLevelComboBox.Visible = this.CancelEditButton.Visible = false;
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            this.refreshProfile();
        }
    }
}
