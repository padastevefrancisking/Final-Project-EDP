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


namespace Final_Project_EDP
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoginBox lb = new LoginBox();
            SignupBox sb = new SignupBox();
            
            LoginPanel.Controls.Add(lb);
            lb.BringToFront();
            lb.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
