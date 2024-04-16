﻿using System;
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
using System.Windows.Forms.ComponentModel.Com2Interop;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using Guna.UI.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            if (!this.VerifyEmail(emailAddress))
                return false;

            con.Open();
            try
            {
                string query = "SELECT uEmailAddress, uPassword FROM Account WHERE uEmailAddress = @emailAddress AND uPassword = @password";
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
                MessageBox.Show("No database connection.");
                return false;
            }
        }
        public bool InsertAccount(Account a)
        {
            if (!this.VerifyEmail(a.EmailAddress))
                return false;

            con.Open();

            string search = "SELECT uEmailAddress FROM Account WHERE uEmailAddress = @emailAddress";
            MySqlCommand command = new MySqlCommand(search, con);

            command.Parameters.AddWithValue("@emailAddress", a.EmailAddress);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sorry. This email has been used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

            string ins = "INSERT INTO Account (firstName, lastName, gender, birthdate, userName, uEmailAddress, uPassword, isAdmin) VALUES (@fName, @lName, @gender, @bday, @userName, @uEmailAddress, @uPassword, @isAdmin)";
            MySqlCommand com = new MySqlCommand(ins, con);

            com.Parameters.AddWithValue("@fName", a.FirstName);
            com.Parameters.AddWithValue("@lName", a.LastName);
            com.Parameters.AddWithValue("@gender", a.Gender);
            com.Parameters.AddWithValue("@bday", a.Birthdate);
            com.Parameters.AddWithValue("@userName", a.Username);
            com.Parameters.AddWithValue("@uEmailAddress", a.EmailAddress);
            com.Parameters.AddWithValue("@uPassword", a.Password);
            com.Parameters.AddWithValue("@isAdmin", a.IsAdmin);

            com.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public Account GetAccount(string emailAddress)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string query = "SELECT firstName, lastName, gender, birthdate, userName, uEmailAddress, uPassword FROM Account WHERE uEmailAddress = @emailAddress";

            List<Account> accs = new List<Account>();

            MySqlCommand com = new MySqlCommand(query, con);
            com.Parameters.AddWithValue("@emailAddress", emailAddress);

            using (MySqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    string fName, lName, uName, email, password;
                    Gender gender;
                    DateTime bday;

                    fName = reader.GetString(0);
                    lName = reader.GetString(1);
                    gender = (Gender)(reader.GetInt32(2));
                    bday = reader.GetDateTime(3);
                    uName = reader.GetString(4);
                    email = reader.GetString(5);
                    password = reader.GetString(6);

                    accs.Add(new Account(fName, lName, gender, bday, uName, email, password));
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
            string insReq = "INSERT INTO Request (RequestLocation, RequestDay, RequestStartTime, RequestEndTime, TutoredSubject, Remarks, RequestStatus) VALUES (@loc, @day, @start, @end, @subj, @rem, @status)";

            MySqlCommand com1 = new MySqlCommand(insReq, con, t);
            com1.Parameters.AddWithValue("@loc", r.RequestLocation);
            com1.Parameters.AddWithValue("@day", r.RequestDay);
            com1.Parameters.AddWithValue("@start", r.RequestTimeStart);
            com1.Parameters.AddWithValue("@end", r.RequestTimeEnd);
            com1.Parameters.AddWithValue("@subj", r.TutoredSubject);
            com1.Parameters.AddWithValue("@rem", r.Remarks);
            com1.Parameters.AddWithValue("@status", r.RequestStatus);

            com1.ExecuteNonQuery();

            string lastInsertIdQuery = "SELECT LAST_INSERT_ID()";
            MySqlCommand lastInsertIdCommand = new MySqlCommand(lastInsertIdQuery, con, t);

            int reqID = Convert.ToInt32(lastInsertIdCommand.ExecuteScalar());
            r.RequestID = reqID;

            t.Commit();

            
            for(int i = 0; i < r.Tutees.Count; i++)
            {
                string insTuts = "INSERT INTO TuteeList (RequestID, TuteeEmail) VALUES (@req, @email)";
                MySqlCommand com2 = new MySqlCommand(insTuts, con);
                com2.Parameters.AddWithValue("@req", reqID);
                com2.Parameters.AddWithValue("@email", r.Tutees[i].EmailAddress);

                com2.ExecuteNonQuery();
            }

            con.Close();
        }

        public void UpdateRequestTable(GunaDataGridView dgv, int mode, string email, int rep)
        {
            con.Open();

            string qry;
            if (mode == 0)
            {
                qry = "SELECT r.RequestDay AS Schedule, t.TagName AS Subject, r.RequestID AS ID, r.RequestLocation AS Location, CASE WHEN EXISTS ( SELECT 1 FROM TuteeList WHERE RequestID = r.RequestID AND TuteeEmail = @email) AND EXISTS ( SELECT 1 FROM TuteeList WHERE RequestID = r.RequestID ) THEN ( SELECT COUNT(*) FROM TuteeList WHERE RequestID = r.RequestID ) ELSE 0 END AS Tutees, CONCAT(DATE_FORMAT(r.RequestStartTime, '%h:%m'), CASE WHEN HOUR(r.RequestStartTime) < 12 THEN ' AM' ELSE ' PM' END) AS Start, CONCAT(DATE_FORMAT(r.RequestEndTime, '%h:%m'), CASE WHEN HOUR(r.RequestEndTime) < 12 THEN ' AM' ELSE ' PM' END) AS End, r.Remarks AS Remarks, r.RequestStatus as Status FROM Request r INNER JOIN Tags t ON r.TutoredSubject = t.TagsID WHERE r.RequestStatus = 0 ORDER BY r.RequestDay ASC";
            }

            else
            {
                qry = "SELECT r.RequestID AS ID, r.RequestDay AS Schedule, t.TagName AS Subject, r.RequestLocation AS Location, CASE WHEN EXISTS ( SELECT 1 FROM TuteeList WHERE RequestID = r.RequestID AND TuteeEmail = @email) THEN 0 ELSE ( SELECT COUNT(DISTINCT TuteeEmail) FROM TuteeList WHERE RequestID = r.RequestID ) END AS Tutees, CONCAT(DATE_FORMAT(r.RequestStartTime, '%h:%m'), CASE WHEN HOUR(r.RequestStartTime) < 12 THEN ' AM' ELSE ' PM' END) AS Start, CONCAT(DATE_FORMAT(r.RequestEndTime, '%h:%m'), CASE WHEN HOUR(r.RequestEndTime) < 12 THEN ' AM' ELSE ' PM' END) AS End, r.Remarks AS Remarks, r.RequestStatus as Status FROM Request r INNER JOIN Tags t ON r.TutoredSubject = t.TagsID WHERE r.RequestStatus = 0 ORDER BY r.RequestDay ASC";
            }

            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@email", email);

            if(rep > 0)
            {
                dgv.Columns.Remove("dgvDetails");
                dgv.Columns.Remove("dgvEdit");
                dgv.Columns.Remove("dgvDelete");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);


            dgv.DataSource = dt;

            dgv.Columns["Schedule"].DefaultCellStyle.Format = "dddd, MMM dd";
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Status"].Visible = false;



            DataGridViewButtonColumn dgvDetails = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvEdit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvDelete = new DataGridViewButtonColumn();

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

            dgv.Columns.Add(dgvDetails);
            dgv.Columns.Add(dgvEdit);
            dgv.Columns.Add(dgvDelete);


            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = dt.Rows[i];
                if (r["Tutees"].ToString() == "0")
                    dt.Rows.Remove(r);
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

            con.Close();
            return tags;
        }

        public int GetNumberOfRequests(Account a)
        {
            con.Open();

            string qry = "SELECT COUNT(*) AS RequestCount FROM TuteeList tl INNER JOIN Request r ON tl.requestID = r.requestID WHERE tl.tuteeEmail = @tEmail";

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
        public List<Account> SearchAccount(Account a, string username)
        {
            con.Open();

            if (username == string.Empty)
                return null;

            string qry = "SELECT isAdmin, uEmailAddress, firstName, lastName, gender, birthdate, userName, uPassword FROM Account WHERE userName LIKE '%" + username + "%'";
            
            MySqlCommand cmd = new MySqlCommand(qry, con);

            List<Account> accs = new List<Account>();
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                bool isAdmin = dr.GetBoolean(0);

                if (!isAdmin )
                {
                    string fName, lName, email, uName, password;
                    Gender gender;
                    DateTime bday;

                    email = dr.GetString(1);
                    fName = dr.GetString(2);
                    lName = dr.GetString(3);
                    gender = (Gender)(dr.GetInt32(4));
                    bday = dr.GetDateTime(5);
                    uName = dr.GetString(6);
                    password = dr.GetString(7);

                    accs.Add(new Account(fName, lName, gender, bday, uName, email, password));
                }
            }

            con.Close();
            return accs;
        }

        public bool IsUniqueEmail(string emailAddress)
        {
            con.Open();
            bool res = true;

            string qry = "SELECT uEmailAddress FROM Account WHERE uEmailAddress = @email";
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
            string qryAccs = "SELECT r.*, a.* FROM Request r LEFT JOIN Tuteelist t ON r.RequestID = t.RequestID LEFT JOIN Account a ON t.TuteeEmail = a.uEmailAddress WHERE r.RequestID = @reqID";

            MySqlCommand cmd = new MySqlCommand(qryAccs, con);
            cmd.Parameters.AddWithValue("@reqID", reqID);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
                accEmail.Add(dr["uEmailAddress"].ToString());

            if (con.State != ConnectionState.Open)
                con.Open();

            List<Account> accs = new List<Account>();
            foreach (string s in accEmail)
                accs.Add(this.GetAccount(s));

            Request res = new Request(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), Convert.ToDateTime(dt.Rows[0][2]), Convert.ToDateTime(dt.Rows[0][3]), Convert.ToDateTime(dt.Rows[0][4]), Convert.ToInt32(dt.Rows[0][5]), accs, dt.Rows[0][6].ToString(), (RequestStatus)(dt.Rows[0][7]));

            return res;
        }
        public void UpdateRequest(int reqID, Request edit)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            string updReqQry = "UPDATE Request SET RequestLocation = @reqLoc, RequestDay = @reqDay, RequestStartTime = @reqStart, RequestEndTime = @reqEnd, TutoredSubject = @subj, Remarks = @remarks WHERE RequestID = @reqID";

            MySqlCommand updReqCmd = new MySqlCommand(updReqQry, con);
            updReqCmd.Parameters.AddWithValue("@reqLoc", edit.RequestLocation);
            updReqCmd.Parameters.AddWithValue("@reqDay", edit.RequestDay);
            updReqCmd.Parameters.AddWithValue("@reqStart", edit.RequestTimeStart);
            updReqCmd.Parameters.AddWithValue("@reqEnd", edit.RequestTimeEnd);
            updReqCmd.Parameters.AddWithValue("@subj", edit.TutoredSubject);
            updReqCmd.Parameters.AddWithValue("@remarks", edit.Remarks);
            updReqCmd.Parameters.AddWithValue("@reqID", reqID);

            updReqCmd.ExecuteNonQuery();

            string tempQry = "CREATE TABLE TempEmails (TuteeEmail varchar(255) PRIMARY KEY)";

            MySqlCommand tempCmd = new MySqlCommand(tempQry, con);
            tempCmd.ExecuteNonQuery();

            foreach (Account a in edit.Tutees)
            {
                string insTempQry = "INSERT INTO TempEmails (TuteeEmail) VALUES (@email)";

                MySqlCommand insTempCmd = new MySqlCommand(insTempQry, con);
                insTempCmd.Parameters.AddWithValue("@email", a.EmailAddress);
                insTempCmd.ExecuteNonQuery();
            }

            string updTuteeQry = "INSERT IGNORE INTO TuteeList (RequestID, TuteeEmail) SELECT @reqID AS RequestID, te.TuteeEmail  FROM TempEmails te WHERE NOT EXISTS ( SELECT 1 FROM TuteeList tl  WHERE tl.RequestID = @reqID  AND tl.TuteeEmail = te.TuteeEmail)";
            MySqlCommand updTuteeCmd = new MySqlCommand(updTuteeQry, con);
            updTuteeCmd.Parameters.AddWithValue("@reqID", reqID);
            updTuteeCmd.ExecuteNonQuery();

            string delDupsQry = "DELETE FROM TuteeList tl  WHERE RequestID = @reqID  AND tl.TuteeEmail NOT IN (SELECT TuteeEmail FROM TempEmails)";
            MySqlCommand delDupsCmd = new MySqlCommand(delDupsQry, con);
            delDupsCmd.Parameters.AddWithValue("@reqID", reqID);
            delDupsCmd.ExecuteNonQuery();

            string drpTempQry = "DROP Table TempEmails";
            MySqlCommand drpTempCmd = new MySqlCommand(drpTempQry, con);
            drpTempCmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
