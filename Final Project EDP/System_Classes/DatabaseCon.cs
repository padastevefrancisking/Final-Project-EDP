using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_EDP.System_Classes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Final_Project_EDP
{
    public class DatabaseCon
    {
        readonly MySqlConnection con = new MySqlConnection("Server=localhost; database=edpsql_schema; uid = root; password = R3m3mb3r_");
        readonly string emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        
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
    }
}
