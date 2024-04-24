using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.ComponentModel.Com2Interop;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using Guna.UI.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using Mysqlx.Crud;
using System.Data.SqlTypes;

namespace Final_Project_EDP
{
    public class DatabaseCon
    {
        public readonly MySqlConnection con = new MySqlConnection("Server=localhost; database=edpsql_schema; uid = root; password = R3m3mb3r_");
        public readonly string emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        
        public bool VerifyEmail(string emailAddress)
        {
            Regex reg= new Regex(emailPattern);
            if (!reg.IsMatch(emailAddress))
            {
                    MessageBox.Show("Invalid Email.");
                    return false;
            }
            return true;
        }
        public bool VerifyLoginInformation(string emailAddress, string password)
        {
            if (!this.VerifyEmail(emailAddress) && !this.IsUniqueEmail(emailAddress))
                return false;

            con.Open();
            try
            {
                string query = "SELECT EmailAddress, UserPassword FROM Account WHERE EmailAddress = @emailAddress AND UserPassword = @password";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@emailAddress", emailAddress);
                command.Parameters.AddWithValue("@password", password);

                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                bool ret = true;
                if (dt.Rows.Count == 0)
                {
                    ret = false;
                    MessageBox.Show("Wrong Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool InsertAccount(Account a)
        {
            if (!this.VerifyEmail(a.EmailAddress) && !this.IsUniqueEmail(a.EmailAddress))
                return false;

            con.Open();

            string ins = "INSERT INTO Account (EmailAddress, FirstName, LastName, ProfilePicture, College, DegreeProgram, YearLevel, UserPassword) VALUES (@email, @fName, @lName, @prof, @college, @degProg, @yearLevel, @pass)";
            MySqlCommand com = new MySqlCommand(ins, con);

            com.Parameters.AddWithValue("@email", a.EmailAddress);
            com.Parameters.AddWithValue("@fName", a.FirstName);
            com.Parameters.AddWithValue("@lName", a.LastName);
            com.Parameters.AddWithValue("@prof", a.ImagePath);
            com.Parameters.AddWithValue("@college", a.College);
            com.Parameters.AddWithValue("@degProg", a.DegreeProgram);
            com.Parameters.AddWithValue("@yearLevel", a.YearLevel);
            com.Parameters.AddWithValue("@pass", a.UserPassword);

            com.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public Account GetAccount(string emailAddress)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string query = "SELECT EmailAddress, FirstName, LastName, ProfilePicture, YearLevel, UserPassword FROM Account WHERE EmailAddress = @emailAddress";

            List<Account> accs = new List<Account>();

            MySqlCommand com = new MySqlCommand(query, con);
            com.Parameters.AddWithValue("@emailAddress", emailAddress);

            using (MySqlDataReader dr = com.ExecuteReader())
            {
                while (dr.Read())
                {
                    string email, fName, lName, pass;
                    int year;
                    byte[] prof;


                    email = dr.GetString("EmailAddress");
                    fName = dr.GetString("FirstName");
                    lName = dr.GetString("LastName");
                    prof = (byte[])dr["ProfilePicture"];
                    year = dr.GetInt32("YearLevel");
                    pass = dr.GetString("UserPassword");


                    accs.Add(new Account(email, fName, lName, prof, year, pass));
                }

                con.Close();
            }

            Account r;
            if (accs.Count > 0)
                r = accs.ElementAt(0);
            else
                r = null;

            return r;
        }
        public void InsertRequest(Request r)
        {
            con.Open();

            MySqlTransaction t = con.BeginTransaction();
            string insReq = "INSERT INTO Request (RequestLocation, Requestee, RequestDay, RequestStartTime, RequestEndTime, TutoredSubjects, Remarks, RequestStatus) VALUES (@loc, @reqee, @day, @start, @end, @subj, @rem, @rStatus)";

            MySqlCommand com1 = new MySqlCommand(insReq, con, t);
            com1.Parameters.AddWithValue("@loc", r.RequestLocation);
            com1.Parameters.AddWithValue("@reqee", r.Requestee.EmailAddress);
            com1.Parameters.AddWithValue("@day", r.RequestDay);
            com1.Parameters.AddWithValue("@start", r.RequestTimeStart);
            com1.Parameters.AddWithValue("@end", r.RequestTimeEnd);
            com1.Parameters.AddWithValue("@subj", r.TutoredSubjects);
            com1.Parameters.AddWithValue("@rem", r.Remarks);
            com1.Parameters.AddWithValue("@rStatus", r.RequestStatus);

            com1.ExecuteNonQuery();

            string lastInsertIdQuery = "SELECT LAST_INSERT_ID()";
            MySqlCommand lastInsertIdCommand = new MySqlCommand(lastInsertIdQuery, con, t);

            int reqID = Convert.ToInt32(lastInsertIdCommand.ExecuteScalar());
            r.RequestID = reqID;

            t.Commit();

            
            for(int i = 0; i < r.Tutees.Count; i++)
            {
                string insTuts = "INSERT INTO TuteeList (TuteeList_RequestID, TuteeList_TuteeEmail, IsIncluded) VALUES (@req, @email, @isInc)";
                MySqlCommand com2 = new MySqlCommand(insTuts, con);
                com2.Parameters.AddWithValue("@req", reqID);
                com2.Parameters.AddWithValue("@email", r.Tutees[i].EmailAddress);
                com2.Parameters.AddWithValue("@isInc", true);

                com2.ExecuteNonQuery();
            }

            con.Close();
        }
        public void UpdateRequestTable(GunaDataGridView dgv, int mode, string email, int rep)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string qry;
            if (mode == 0)
            {
                qry = "SELECT r.RequestID AS ID, r.Requestee AS Requestee, r.RequestDay AS Schedule, t.TagName AS Subject, r.RequestLocation AS Location, (SELECT COUNT(*) FROM TuteeList WHERE TuteeList_RequestID = r.RequestID AND IsIncluded = true) AS Tutees, CONCAT(DATE_FORMAT(r.RequestStartTime, '%h:%m'), CASE WHEN HOUR(r.RequestStartTime) < 12 THEN ' AM' ELSE ' PM' END, \" - \", DATE_FORMAT(r.RequestEndTime, '%h:%m'), CASE WHEN HOUR(r.RequestEndTime) < 12 THEN ' AM' ELSE ' PM' END) AS Time, r.Remarks AS Remarks, r.RequestStatus AS Status FROM Request r LEFT JOIN Tags t ON r.TutoredSubjects = t.TagsID WHERE r.RequestStatus = 0 AND EXISTS ( SELECT 1 FROM TuteeList tl WHERE tl.TuteeList_RequestID = r.RequestID AND tl.IsIncluded = true AND tl.TuteeList_TuteeEmail = @email AND r.RequestStatus = 0) ORDER BY r.RequestDay ASC";
            }

            else
            {
                qry = "SELECT r.RequestID AS ID, r.Requestee AS Requestee, r.RequestDay AS Schedule, t.TagName AS Subject, r.RequestLocation AS Location, (SELECT COUNT(*) FROM TuteeList WHERE TuteeList_RequestID = r.RequestID AND IsIncluded = true) AS Tutees, CONCAT(DATE_FORMAT(r.RequestStartTime, '%h:%m'), CASE WHEN HOUR(r.RequestStartTime) < 12 THEN ' AM' ELSE ' PM' END, \" - \", DATE_FORMAT(r.RequestEndTime, '%h:%m'), CASE WHEN HOUR(r.RequestEndTime) < 12 THEN ' AM' ELSE ' PM' END) AS Time, r.Remarks AS Remarks, r.RequestStatus AS Status FROM Request r LEFT JOIN Tags t ON r.TutoredSubjects = t.TagsID WHERE r.RequestStatus = 0 AND NOT EXISTS ( SELECT 1 FROM TuteeList tl WHERE tl.TuteeList_RequestID = r.RequestID AND tl.IsIncluded = true AND tl.TuteeList_TuteeEmail = @email ) AND NOT EXISTS ( SELECT 1 FROM DenyRequest dr WHERE dr.DenyRequest_RequestID = r.RequestID AND dr.DenyRequest_TuteeEmail = @email AND dr.IsRevoked = 0 ) ORDER BY r.RequestDay ASC";
            }

            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@email", email);

            if(rep > 0)
            {
                dgv.Columns.Remove("dgvDetails");
                dgv.Columns.Remove("dgvEdit");
                dgv.Columns.Remove("dgvDelete");
                dgv.Columns.Remove("dgvAccept");
                dgv.Columns.Remove("dgvDeny");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);

            dgv.DataSource = dt;

            dgv.Columns["Schedule"].DefaultCellStyle.Format = "dddd, MMM dd";
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Status"].Visible = false;
            dgv.Columns["Requestee"].Visible = false;

            DataGridViewButtonColumn dgvDetails = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvAccept = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvDeny = new DataGridViewButtonColumn();

            dgvDetails.Name = "dgvDetails";
            dgvDetails.HeaderText = "";
            dgvDetails.ReadOnly = false;
            dgvDetails.Text = "Details";
            dgvDetails.FlatStyle = FlatStyle.Popup;
            dgvDetails.UseColumnTextForButtonValue = true;

            dgvEdit.Name = "dgvEdit";
            dgvEdit.HeaderText = "";
            dgvEdit.ReadOnly = false;
            dgvEdit.Text = "Edit";
            dgvEdit.FlatStyle = FlatStyle.Popup;
            dgvEdit.UseColumnTextForButtonValue = true;

            dgvDelete.Name = "dgvDelete";
            dgvDelete.HeaderText = "";
            dgvDelete.ReadOnly = false;
            dgvDelete.Text = "Delete";
            dgvDelete.FlatStyle = FlatStyle.Popup;
            dgvDelete.UseColumnTextForButtonValue = true;

            dgvAccept.Name = "dgvAccept";
            dgvAccept.HeaderText = "";
            dgvAccept.ReadOnly = false;
            dgvAccept.Text = "Accept";
            dgvAccept.FlatStyle = FlatStyle.Popup;
            dgvAccept.UseColumnTextForButtonValue = true;

            dgvDeny.Name = "dgvDeny";
            dgvDeny.HeaderText = "";
            dgvDeny.ReadOnly = false;
            dgvDeny.Text = "Deny";
            dgvDeny.FlatStyle = FlatStyle.Popup;
            dgvDeny.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(dgvDetails);
            dgv.Columns.Add(dgvEdit);
            dgv.Columns.Add(dgvDelete);
            dgv.Columns.Add(dgvAccept);
            dgv.Columns.Add(dgvDeny);

            foreach(DataGridViewColumn daCo in dgv.Columns)
                daCo.SortMode = DataGridViewColumnSortMode.NotSortable;

            if(mode  == 1)
            {
                dgv.Columns["dgvEdit"].Visible = dgv.Columns["dgvDelete"].Visible = false;
                dgv.Columns["dgvAccept"].Visible = dgv.Columns["dgvDeny"].Visible = true;
            }
            else
            {
                dgv.Columns["dgvEdit"].Visible = dgv.Columns["dgvDelete"].Visible = true;
                dgv.Columns["dgvAccept"].Visible = dgv.Columns["dgvDeny"].Visible = false;
            }

            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = dt.Rows[i];
                if (Convert.ToString(r["Requestee"]) != email)
                {
                    dgv["dgvEdit", i].ReadOnly = true;
                    dgv["dgvEdit", i] = new DataGridViewTextBoxCell();
                }

            }
        }
        public int GetTagsID(string TagsName)
        {
            con.Open();

            string qryTags = "SELECT TagsID FROM Tags WHERE TagName = @tName";

            MySqlCommand cm = new MySqlCommand(qryTags, con);
            cm.Parameters.AddWithValue("@tName", TagsName);

            List<int> tagID = new List<int>();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
                tagID.Add(dr.GetInt32(0));

            int r;
            if(tagID.Count > 0)
                r = tagID[0];
            else r = 0;

            con.Close();
            return r;
        }
        public List<string> GetTags()
        {
            con.Open();

            string qryTL = "SELECT TagName FROM Tags";
            MySqlCommand cmd = new MySqlCommand(qryTL, con);

            List<string> tags = new List<string>();
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
                tags.Add(dr.GetString(0));

            string r = "";
            foreach (string s in tags)
                r += s + "\n";

            MessageBox.Show(r);

            con.Close();
            return tags;
        }
        public int GetNumberOfRequests(Account a)
        {
            con.Open();

            string qry = "SELECT COUNT(*) AS RequestCount FROM TuteeList tl INNER JOIN Request r ON tl.TuteeList_RequestID = r.RequestID WHERE tl.TuteeList_TuteeEmail = @tEmail AND tl.IsIncluded = true AND r.RequestStatus = 0";

            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@tEmail", a.EmailAddress);

            MySqlDataReader dr = cmd.ExecuteReader();

            List<Int32> count = new List<Int32>();
            while(dr.Read())
                count.Add(dr.GetInt32(0));

            int r = -1;
            if(count.Count > 0)
                r = count[0];

            con.Close();
            return r;
        }
        public List<Account> SearchAccount(Account a, string srchEntry)
        {
            con.Open();

            if (srchEntry == string.Empty)
                return null;

            string qry = "SELECT EmailAddress, FirstName, LastName, ProfilePicture, YearLevel, UserPassword FROM Account WHERE CONCAT(FirstName, \" \", LastName) LIKE '%" + srchEntry + "%'";
            
            MySqlCommand cmd = new MySqlCommand(qry, con);

            List<Account> accs = new List<Account>();
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                string email, fName, lName, pass;
                byte[] prof;
                int year;

                email = dr.GetString("EmailAddress");
                fName = dr.GetString("FirstName");
                lName = dr.GetString("LastName");
                prof = (byte[])dr["ProfilePicture"];
                year = dr.GetInt32("YearLevel");
                pass = dr.GetString("UserPassword");

                accs.Add(new Account(email, fName, lName, prof, year, pass));
            }

            con.Close();
            return accs;
        }
        public bool IsUniqueEmail(string emailAddress)
        {
            con.Open();
            bool res = true;

            string qry = "SELECT EmailAddress FROM Account WHERE EmailAddress = @email";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@email", emailAddress);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                res = false;

            con.Close();
            return res;

        }
        public Request GetRequest(int reqID)
        {
            con.Open();

            List<string> accEmail = new List<string>();
            string qryAccs = "SELECT r.*, a.* FROM Request r LEFT JOIN Tuteelist t ON r.RequestID = t.TuteeList_RequestID LEFT JOIN Account a ON t.TuteeList_TuteeEmail = a.EmailAddress WHERE r.RequestID = @reqID";

            MySqlCommand cmd = new MySqlCommand(qryAccs, con);
            cmd.Parameters.AddWithValue("@reqID", reqID);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
                accEmail.Add(dr["EmailAddress"].ToString());

            if (con.State != ConnectionState.Open)
                con.Open();

            List<Account> accs = new List<Account>();
            foreach (string s in accEmail)
            {
                accs.Add(this.GetAccount(s));
                if (con.State == ConnectionState.Closed) { con.Open(); }
                MessageBox.Show(this.GetAccount(s).ToString());
            }
            DataRow dr2 = dt.Rows[0];
            Account a = this.GetAccount(Convert.ToString(dr2["Requestee"]));

            if (con.State != ConnectionState.Open)
                con.Open();

            int req = Convert.ToInt32(dr2["RequestID"]);
            string loc = Convert.ToString(dr2["RequestLocation"]);
            DateTime day = Convert.ToDateTime(dr2["RequestDay"]);
            DateTime st = Convert.ToDateTime(dr2["RequestStartTime"]);
            DateTime en = Convert.ToDateTime(dr2["RequestEndTime"]);
            int sub = Convert.ToInt32(dr2["TutoredSubjects"]);
            string rem = Convert.ToString(dr2["Remarks"]);
            RequestStatus reS = (RequestStatus)(Convert.ToInt32(dr2["RequestStatus"]));

            MessageBox.Show(a + "\n" + req + "\n" + loc + "\n" + day.ToString() + "\n" + st.ToString() + "\n" + en.ToString() + "\n" + sub + "\n" + rem + reS.ToString());

            Convert.ToString(dr2["RequestLocation"]);

            Request res = new Request(reqID, a, loc, day, st, en, sub, accs, rem, reS);

            
            MessageBox.Show(res.ToString());
            return res;
        }
        public void UpdateRequest(int reqID, Request edit)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string updReqQry = "UPDATE Request SET RequestLocation = @reqLoc, RequestDay = @reqDay, RequestStartTime = @reqStart, RequestEndTime = @reqEnd, TutoredSubjects = @subj, Remarks = @remarks, RequestStatus = @rStatus WHERE RequestID = @reqID";

            MySqlCommand updReqCmd = new MySqlCommand(updReqQry, con);
            updReqCmd.Parameters.AddWithValue("@reqLoc", edit.RequestLocation);
            updReqCmd.Parameters.AddWithValue("@reqDay", edit.RequestDay);
            updReqCmd.Parameters.AddWithValue("@reqStart", edit.RequestTimeStart);
            updReqCmd.Parameters.AddWithValue("@reqEnd", edit.RequestTimeEnd);
            updReqCmd.Parameters.AddWithValue("@subj", edit.TutoredSubjects);
            updReqCmd.Parameters.AddWithValue("@remarks", edit.Remarks);
            updReqCmd.Parameters.AddWithValue("@reqID", reqID);
            updReqCmd.Parameters.AddWithValue("@rStatus", edit.RequestStatus);

            updReqCmd.ExecuteNonQuery();

            string tempQry = "CREATE TABLE TempEmails (TuteeEmail varchar(255) PRIMARY KEY)";

            MySqlCommand tempCmd = new MySqlCommand(tempQry, con);
            tempCmd.ExecuteNonQuery();

            string notIncQry = "UPDATE TuteeList SET IsIncluded = 0 WHERE TuteeList_RequestID = @reqID";
            MySqlCommand notIncCmd = new MySqlCommand(notIncQry, con);
            notIncCmd.Parameters.AddWithValue("@reqID", reqID);
            notIncCmd.ExecuteNonQuery();

            foreach (Account a in edit.Tutees)
            {
                string insTempQry = "INSERT INTO TempEmails (TuteeEmail) VALUES (@email)";

                MySqlCommand insTempCmd = new MySqlCommand(insTempQry, con);
                insTempCmd.Parameters.AddWithValue("@email", a.EmailAddress);
                insTempCmd.ExecuteNonQuery();
            }

            string incQry = "UPDATE TuteeList tl SET IsIncluded = CASE WHEN EXISTS (SELECT 1 FROM TempEmails te WHERE te.TuteeEmail = tl.TuteeList_TuteeEmail) THEN 1  ELSE 0 END WHERE tl.TuteeList_RequestID = @reqID";
            MySqlCommand incCmd = new MySqlCommand(incQry, con);
            incCmd.Parameters.AddWithValue("@reqID", reqID);
            incCmd.ExecuteNonQuery();

            string updTuteeQry = "INSERT IGNORE INTO TuteeList (TuteeList_RequestID, IsIncluded, TuteeList_TuteeEmail) SELECT @reqID AS RequestID, @isInc, te.TuteeEmail  FROM TempEmails te WHERE NOT EXISTS ( SELECT 1 FROM TuteeList tl  WHERE tl.TuteeList_RequestID = @reqID  AND tl.TuteeList_TuteeEmail = te.TuteeEmail)";
            MySqlCommand updTuteeCmd = new MySqlCommand(updTuteeQry, con);
            updTuteeCmd.Parameters.AddWithValue("@reqID", reqID);
            updTuteeCmd.Parameters.AddWithValue("@isInc", true);
            updTuteeCmd.ExecuteNonQuery();

            string drpTempQry = "DROP Table TempEmails";
            MySqlCommand drpTempCmd = new MySqlCommand(drpTempQry, con);
            drpTempCmd.ExecuteNonQuery();

            con.Close();
        }
        public void DeleteRequest(Request req)
        {
            if(con.State != ConnectionState.Open) { con.Open(); }
            {
                req.RequestStatus = RequestStatus.Deleted;
                this.UpdateRequest(req.RequestID, req);

            }

            if (con.State != ConnectionState.Closed) { con.Close(); }
        }
        public void DenyRequest(Request req, Account acc)
        {
            if (con.State != ConnectionState.Open) { con.Open(); }

            string dnyQry = "INSERT INTO DenyRequest (DenyRequest_RequestID, DenyRequest_TuteeEmail, IsRevoked) VALUES (@reqID, @email, @isRev)";
            MySqlCommand dnyCmd = new MySqlCommand(dnyQry, con);
            dnyCmd.Parameters.AddWithValue("@reqID", req.RequestID);
            dnyCmd.Parameters.AddWithValue("email", acc.EmailAddress);
            dnyCmd.Parameters.AddWithValue("@isRev", false);

            dnyCmd.ExecuteNonQuery();
            if (con.State != ConnectionState.Closed) { con.Close(); };
        }
        public void AcceptRequest(Request req, Account acc, string desc, string tRemarks)
        {
            try
            {
                Schedule s = new Schedule(req, acc, desc, req.RequestLocation, req.RequestDay, req.RequestTimeStart, req.RequestTimeEnd, req.TutoredSubjects, req.Tutees, tRemarks);
                MessageBox.Show(req.ToString() + "\n" + s.RequestBased + "\n" + req.Requestee + "\n" + s.Tutees[0]);

                if (con.State != ConnectionState.Open) { con.Open(); }

                MySqlTransaction t = con.BeginTransaction();
                string qry = "INSERT INTO Schedule (Schedule_RequestID, Schedule_TutorEmail, ScheduleDescription, ScheduleLocation, ScheduleDay, ScheduleStartTime, ScheduleEndTime, Subjects, TutorRemarks, ScheduleStatus) VALUES (@sReqID, @sEmail, @desc, @sLoc, @sDay, @sStart, @sEnd, @subj, @tRem, @sStat)";

                MySqlCommand cmd = new MySqlCommand(qry, con, t);
                cmd.Parameters.AddWithValue("@sReqID", s.RequestBased.RequestID);
                cmd.Parameters.AddWithValue("@sEmail", s.Tutor.EmailAddress);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@sLoc", s.ScheduleLocation);
                cmd.Parameters.AddWithValue("@sDay", s.ScheduleDay);
                cmd.Parameters.AddWithValue("@sStart", s.ScheduleTimeStart);
                cmd.Parameters.AddWithValue("@sEnd", s.ScheduleTimeEnd);
                cmd.Parameters.AddWithValue("@subj", s.TutoredSubject);
                cmd.Parameters.AddWithValue("@tRem", s.Remarks);
                cmd.Parameters.AddWithValue("@sStat", s.ScheduleStatus);
                cmd.ExecuteNonQuery();

                string lastInsertIdQuery = "SELECT LAST_INSERT_ID()";
                MySqlCommand lastInsertIdCommand = new MySqlCommand(lastInsertIdQuery, con, t);

                int schedID = Convert.ToInt32(lastInsertIdCommand.ExecuteScalar());
                s.ScheduleID = schedID;

                t.Commit();



                for (int i = 0; i < s.Tutees.Count; i++)
                {
                    string insTutsQry = "INSERT INTO ScheduleTutee (ScheduleTutee_ScheduleID, ScheduleTutee_TuteeEmail, IsIncluded) VALUES (@sID, @sEmail, @isInc)";

                    MySqlCommand insTutsCmd = new MySqlCommand(insTutsQry, con);
                    insTutsCmd.Parameters.AddWithValue("@sID", s.ScheduleID);
                    insTutsCmd.Parameters.AddWithValue("@sEmail", s.Tutees[i].EmailAddress);

                    if (s.Tutees[i] == s.RequestBased.Requestee)
                        insTutsCmd.Parameters.AddWithValue("@isInc", true);
                    else
                        insTutsCmd.Parameters.AddWithValue("@isInc", false);

                    insTutsCmd.ExecuteNonQuery();
                }

                string updReqQry = "UPDATE Request SET RequestStatus = @reqStat WHERE RequestID = @reqID";

                MySqlCommand cmd2 = new MySqlCommand(updReqQry, con);
                cmd2.Parameters.AddWithValue("@reqStat", RequestStatus.Accepted);
                cmd2.Parameters.AddWithValue("@reqID", req.RequestID);
                cmd2.ExecuteNonQuery();

                if (con.State != ConnectionState.Closed) { con.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void UpdateScheduleTable(GunaDataGridView dgv, int mode, string email, int rep)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string qry;
            if (mode == 0)
            {
                qry = "SELECT s.ScheduleID AS ID, s.Schedule_RequestID AS Request, s.Schedule_TutorEmail AS Tutor, s.ScheduleDescription AS Description, s.ScheduleLocation AS Location, s.ScheduleDay AS ScheduleDay, s.ScheduleStartTime AS Start, s.ScheduleEndTime AS End, s.Subjects AS Subjects, s.TutorRemarks AS Remarks, s.ScheduleStatus AS Status, COUNT(DISTINCT st.ScheduleTutee_TuteeEmail) AS TuteeCount FROM Schedule s INNER JOIN ScheduleTutee st ON s.ScheduleID = st.ScheduleTutee_ScheduleID WHERE st.ScheduleTutee_TuteeEmail = @email GROUP BY s.ScheduleID, s.ScheduleDay";
            }

            else
            {
                qry = "SELECT r.RequestID AS ID, r.Requestee AS Requestee, r.RequestDay AS Schedule, t.TagName AS Subject, r.RequestLocation AS Location, (SELECT COUNT(*) FROM TuteeList WHERE TuteeList_RequestID = r.RequestID AND IsIncluded = true) AS Tutees, CONCAT(DATE_FORMAT(r.RequestStartTime, '%h:%m'), CASE WHEN HOUR(r.RequestStartTime) < 12 THEN ' AM' ELSE ' PM' END) AS Start, CONCAT(DATE_FORMAT(r.RequestEndTime, '%h:%m'), CASE WHEN HOUR(r.RequestEndTime) < 12 THEN ' AM' ELSE ' PM' END) AS End,      r.Remarks AS Remarks, r.RequestStatus AS Status FROM Request r LEFT JOIN Tags t ON r.TutoredSubjects = t.TagsID WHERE r.RequestStatus = 0 AND NOT EXISTS ( SELECT 1 FROM TuteeList tl WHERE tl.TuteeList_RequestID = r.RequestID AND tl.IsIncluded = true AND tl.TuteeList_TuteeEmail = @email ) AND NOT EXISTS ( SELECT 1 FROM DenyRequest dr WHERE dr.DenyRequest_RequestID = r.RequestID AND dr.DenyRequest_TuteeEmail = @email AND dr.IsRevoked = 0 ) ORDER BY r.RequestDay ASC";
            }

            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@email", email);

            if (rep > 0)
            {
                dgv.Columns.Remove("dgvDetails");
                dgv.Columns.Remove("dgvEdit");
                dgv.Columns.Remove("dgvDelete");
                dgv.Columns.Remove("dgvAccept");
                dgv.Columns.Remove("dgvDeny");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);

            dgv.DataSource = dt;

            dgv.Columns["Schedule"].DefaultCellStyle.Format = "dddd, MMM dd";
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Status"].Visible = false;
            dgv.Columns["Requestee"].Visible = false;

            DataGridViewButtonColumn dgvDetails = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvAccept = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvDeny = new DataGridViewButtonColumn();

            dgvDetails.Name = "dgvDetails";
            dgvDetails.HeaderText = "";
            dgvDetails.ReadOnly = false;
            dgvDetails.Text = "Details";
            dgvDetails.FlatStyle = FlatStyle.Popup;
            dgvDetails.UseColumnTextForButtonValue = true;

            dgvEdit.Name = "dgvEdit";
            dgvEdit.HeaderText = "";
            dgvEdit.ReadOnly = false;
            dgvEdit.Text = "Edit";
            dgvEdit.FlatStyle = FlatStyle.Popup;
            dgvEdit.UseColumnTextForButtonValue = true;

            dgvDelete.Name = "dgvDelete";
            dgvDelete.HeaderText = "";
            dgvDelete.ReadOnly = false;
            dgvDelete.Text = "Delete";
            dgvDelete.FlatStyle = FlatStyle.Popup;
            dgvDelete.UseColumnTextForButtonValue = true;

            dgvAccept.Name = "dgvAccept";
            dgvAccept.HeaderText = "";
            dgvAccept.ReadOnly = false;
            dgvAccept.Text = "Accept";
            dgvAccept.FlatStyle = FlatStyle.Popup;
            dgvAccept.UseColumnTextForButtonValue = true;

            dgvDeny.Name = "dgvDeny";
            dgvDeny.HeaderText = "";
            dgvDeny.ReadOnly = false;
            dgvDeny.Text = "Deny";
            dgvDeny.FlatStyle = FlatStyle.Popup;
            dgvDeny.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(dgvDetails);
            dgv.Columns.Add(dgvEdit);
            dgv.Columns.Add(dgvDelete);
            dgv.Columns.Add(dgvAccept);
            dgv.Columns.Add(dgvDeny);

            foreach (DataGridViewColumn daCo in dgv.Columns)
                daCo.SortMode = DataGridViewColumnSortMode.NotSortable;

            if (mode == 1)
            {
                dgv.Columns["dgvEdit"].Visible = dgv.Columns["dgvDelete"].Visible = false;
                dgv.Columns["dgvAccept"].Visible = dgv.Columns["dgvDeny"].Visible = true;
            }
            else
            {
                dgv.Columns["dgvEdit"].Visible = dgv.Columns["dgvDelete"].Visible = true;
                dgv.Columns["dgvAccept"].Visible = dgv.Columns["dgvDeny"].Visible = false;
            }

            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = dt.Rows[i];
                if (Convert.ToString(r["Requestee"]) != email)
                {
                    dgv["dgvEdit", i].ReadOnly = true;
                    dgv["dgvEdit", i] = new DataGridViewTextBoxCell();
                }

            }
        }

    }
}
