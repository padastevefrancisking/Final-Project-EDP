using Final_Project_EDP.System_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_EDP.System_UserControls
{
    public partial class TuteeSearchResult : UserControl
    {
        public Account a {  get; private set; }
        public RequestFillup rf {  get; private set; }
        public TuteeSearchResult(Account a, RequestFillup rf)
        {
            InitializeComponent();
            this.CompleteNameLabel.Text = a.ToString();
            this.DegreeProgramLabel.Text = a.DegreeProgram;
            this.a = a;
            this.rf = rf;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            this.rf.accs.Add(this.a);
            this.rf.SearchboxResultPanel.Controls.Remove(this);
            this.rf.refreshPanel();
            this.rf.UpdateSearchResult();

        }

    }
}
