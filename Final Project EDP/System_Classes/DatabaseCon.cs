using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Final_Project_EDP
{
    public class DatabaseCon
    {
        public readonly MySqlConnection con = new MySqlConnection("Server=localhost; database=edpsql_schema; uid = root; password = R3m3mb3r_");
        public readonly string emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        
        private bool verifyEmail(string emailAddress)
        {
            Regex reg= new Regex(emailPattern);
            if (!reg.IsMatch(emailAddress))
            {
                    MessageBox.Show("Invalid Email.");
                    return false;
            }
            return true;

        }

        public bool verifyLoginInformation(string emailAddress, string password)
        {
            if (!this.verifyEmail(emailAddress))
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
            if (!this.verifyEmail(a.getEmailAddress()))
                return false;

            con.Open();

            string search = "SELECT uEmailAddress FROM Account WHERE uEmailAddress = @emailAddress";
            MySqlCommand command = new MySqlCommand(search, con);

            command.Parameters.AddWithValue("@emailAddress", a.getEmailAddress());
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

            com.Parameters.AddWithValue("@fName", a.getFirstName());
            com.Parameters.AddWithValue("@lName", a.getLastName());
            com.Parameters.AddWithValue("@gender", a.getGender());
            com.Parameters.AddWithValue("@bday", a.getBirthdate());
            com.Parameters.AddWithValue("@userName", a.getUsername());
            com.Parameters.AddWithValue("@uEmailAddress", a.getEmailAddress());
            com.Parameters.AddWithValue("@uPassword", a.getPassword());
            com.Parameters.AddWithValue("@isAdmin", a.getIsAdmin());

            com.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public Account GetAccount(string emailAddress)
        {
            con.Open();

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

            Account r = accs.ElementAt(0);
            MessageBox.Show(r + "");
            return r;
        }

        public void InsertRequest(Request r)
        {
            con.Open();
            string insReq = "INSERT INTO Request (RequestLocation, RequestDay, RequestStartTime, RequestEndTime, TutoredSubject, RequestStatus) VALUES (@loc, @day, @start, @end, @subj, @status)";

            MySqlCommand com1 = new MySqlCommand(insReq, con);
            com1.Parameters.AddWithValue("@loc", r.RequestLocation);
            com1.Parameters.AddWithValue("@day", r.RequestDay);
            com1.Parameters.AddWithValue("@start", r.RequestTimeStart);
            com1.Parameters.AddWithValue("@end", r.RequestTimeEnd);
            com1.Parameters.AddWithValue("@subj", r.TutoredSubject);
            com1.Parameters.AddWithValue("@status", r.RequestStatus);

            com1.ExecuteNonQuery();

            string insTuts = "INSERT INTO TuteeList (RequestID, TuteeEmail) VALUES (@req, @email)";

            MySqlCommand com2 = new MySqlCommand(insTuts, con);

            for(int i = 0; i < r.Tutees.Count; i++)
            {
                com2.Parameters.AddWithValue("@req", r.RequestID);
                com2.Parameters.AddWithValue("@email", r.Tutees[i].getEmailAddress());

                com2.ExecuteReader();
            }

            con.Close();
        }
    }
}
