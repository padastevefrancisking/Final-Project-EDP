using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Final_Project_EDP.System_Enums;

namespace Final_Project_EDP.System_Classes
{
    public class Account
    {
        private string firstName;
        private string lastName;
        private System_Enums.Gender gender;
        private DateTime birthdate;
        private string degreeProgram;
        private string userName;
        private string emailAddress;
        private string password;
        private bool isAdmin;

        public Account(string firstName, string lastName, Gender gender, DateTime birthdate, string userName, string emailAddress, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthdate = birthdate;
            this.degreeProgram = string.Empty;
            this.userName = userName;
            this.emailAddress = emailAddress;
            this.password = password;
            this.isAdmin = false;
        }

        public override string ToString()
        {
            return "Name: " + this.firstName + " " + this.lastName + "\n Email Address" + this.emailAddress;
        }

        public string getFirstName()
        {
            string r = this.firstName;
            return r;
        }

        public string getLastName()
        {
            string r = this.lastName;
            return r;
        }
        public Gender getGender() 
        {
            Gender r = this.gender;
            return r;
        }
        public DateTime getBirthdate()
        {
            DateTime r = this.birthdate;
            return r;
        }
        public string getDegreeProgram()
        {
            string r = this.degreeProgram;
            return r;
        }
        public string getUsername()
        {
            string r = this.userName;
            return r;
        }
        public string getPassword()
        {
            string r = this.password;
            return r;
        }
        public bool getIsAdmin()
        {
            bool r = this.isAdmin;
            return r;
        }
        public string getEmailAddress()
        {
            string r = this.emailAddress;
            return r;
        }

        
    }
}
