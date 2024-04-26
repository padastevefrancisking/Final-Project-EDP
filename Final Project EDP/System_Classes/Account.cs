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
        public string EmailAddress { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte[] ImagePath { get; private set; }
        public string College { get; private set; }
        public string DegreeProgram { get; private set; }
        public int YearLevel { get; private set; }
        public string UserPassword { get; private set; }

        public Account(string emailAddress, string firstName, string lastName, byte[] imagePath, int yearLevel, string userPassword)
        {
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImagePath = imagePath;
            this.College = "College of Engineering and Technology";
            this.DegreeProgram = "BSCS";
            this.YearLevel = yearLevel;
            this.UserPassword = userPassword;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Account)) return false;
            if (obj == null) return false;

            Account other = obj as Account;
            if (other.EmailAddress == this.EmailAddress)
                return true;
            return false;
        }
    }
}
