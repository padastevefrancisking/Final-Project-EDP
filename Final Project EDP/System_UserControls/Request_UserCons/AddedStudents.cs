using Final_Project_EDP.System_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls.Request_UserCons
{
    public partial class AddedStudents : UserControl
    {
        private Account a;
        private RequestFillup rf;
        public AddedStudents(Account a, RequestFillup rf, int mode)
        {
            InitializeComponent();
            this.a = a;
            this.rf = rf;
            if (mode == 1)
                this.RemoveTuteeButton.Visible = false;

            this.CompleteNameLabel.Text = a.ToString();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.rf.accs.Remove(this.a);
            this.rf.TuteesLayoutPanel.Controls.Remove(this);
        }
    }
}
