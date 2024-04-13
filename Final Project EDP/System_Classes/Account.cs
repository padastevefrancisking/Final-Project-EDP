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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public System_Enums.Gender Gender { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string DegreeProgram { get; private set; }
        public string Username { get; private set; }
        public string EmailAddress { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }

        public Account(string firstName, string lastName, Gender gender, DateTime birthdate, string userName, string emailAddress, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.DegreeProgram = string.Empty;
            this.Username = userName;
            this.EmailAddress = emailAddress;
            this.Password = password;
            this.IsAdmin = false;
        }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            if (obj == null) return false;

            Account other = obj as Account;
            return other.EmailAddress == this.EmailAddress;
        }
    }
}
