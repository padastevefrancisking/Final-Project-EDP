using Final_Project_EDP.System_Classes;
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
            dc.UpdateRequestTable(this.RequestTable, 0, mf.A.EmailAddress, 0);
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
            dc.UpdateRequestTable(this.RequestTable, this.mode, this.mf.A.EmailAddress, 1);
        }

        private void RequestListButton_Click(object sender, EventArgs e)
        {
            this.mode = 1;
            DatabaseCon dc = new DatabaseCon();
            dc.UpdateRequestTable(this.RequestTable, this.mode, this.mf.A.EmailAddress, 1);
        }

        private void RequestTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RequestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == this.RequestTable.Columns["dgvDetails"].Index)
            {
                DataGridViewRow dgvr = this.RequestTable.Rows[e.RowIndex];
                DatabaseCon dc = new DatabaseCon();
                Request r = dc.GetRequest(Convert.ToInt32(dgvr.Cells["ID"].Value));

                MessageBox.Show(r.ToString());
            }
            else if (e.ColumnIndex == this.RequestTable.Columns["dgvEdit"].Index)
            {

                DataGridViewRow dgvr = this.RequestTable.Rows[e.RowIndex];
                DatabaseCon dc = new DatabaseCon();
                Request r = dc.GetRequest(Convert.ToInt32(dgvr.Cells["ID"].Value));

                Form f = new Form();
                RequestFillup rfu = new RequestFillup(f, this, r);
                f.Controls.Add(rfu);
                rfu.Dock = DockStyle.Fill;
                f.ShowDialog();
            }
            else if (e.ColumnIndex == this.RequestTable.Columns["dgvDelete"].Index)
            {
                MessageBox.Show("Hello");
                DataGridViewRow dgvr = this.RequestTable.Rows[e.RowIndex];
                DatabaseCon dc = new DatabaseCon();
                Request r = dc.GetRequest(Convert.ToInt32(dgvr.Cells["ID"].Value));

                r.RequestStatus = System_Enums.RequestStatus.Deleted;
                dc.UpdateRequestTable(this.RequestTable, this.mode, this.mf.A.EmailAddress, 1);
            }

        }
    }
}
