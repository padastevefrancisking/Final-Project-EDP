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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoginBackground.BackColor = Color.FromArgb(7, 47, 95);
            LoginInside li = new LoginInside();
            
            li.TopLevel = false;
            LoginBackground.Controls.Add(li);
            li.BringToFront();
            li.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
