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
        public LoginBox lb { get; private set; }
        public SignupBox sb { get; private set; }
        public MainMenu()
        {
            InitializeComponent();
            lb = new LoginBox(this);
            sb = new SignupBox(this);
            
            LoginPanel.Controls.Add(lb);
            LoginPanel.Controls.Add(sb);
            lb.BringToFront();
            lb.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
