using Final_Project_EDP.System_Forms;
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
    public partial class Requests : UserControl
    {
        public int mode {  get; private set; }
        public MainForm mf {  get; private set; }
        public Requests(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.mode = 0;
            
            DatabaseCon dc = new DatabaseCon();
            dc.updateRequestTable(this.RequestTable, 0, mf.A.EmailAddress);
        }

        private void AddRequestButton_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            RequestFillup rfu = new RequestFillup(f, this);
            f.Controls.Add(rfu);
            rfu.Dock = DockStyle.Fill;
            f.ShowDialog();
        }

        private void PendingRequestsButton_Click(object sender, EventArgs e)
        {
            this.mode = 0;
            DatabaseCon dc = new DatabaseCon();
            dc.updateRequestTable(this.RequestTable, this.mode, this.mf.A.EmailAddress);
        }

        private void RequestListButton_Click(object sender, EventArgs e)
        {
            this.mode = 1;
            DatabaseCon dc = new DatabaseCon();
            dc.updateRequestTable(this.RequestTable, this.mode, this.mf.A.EmailAddress);
        }
    }
}
