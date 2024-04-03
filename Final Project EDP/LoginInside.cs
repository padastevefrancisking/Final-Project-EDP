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
    public partial class LoginInside : Form
    {
        public LoginInside()
        {
            InitializeComponent();
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {

        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Steve Pada" && PasswordTextbox.Text == "yes")
                Application.Exit();
        }
    }
}
