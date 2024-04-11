using Final_Project_EDP.System_Classes;
using Final_Project_EDP.System_Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Final_Project_EDP.System_UnitTests
{
    public class RequestTest
    {
        [Fact]
        public void TestEquals()
        {
            DateTime bday = DateTime.Now;
            Account a = new Account("Steve Francis King", "Pada", Gender.Male, bday, "AlgebraicWeirdo03", "padastevefrancisking@gmail.com", "hiyyih");

            Account b = new Account("Steve Francis King", "Pada", Gender.Male, bday, "AlgebraicWeirdo03", "padastevefrancisking@gmail.com", "hiyyih");

            Assert.Equal(a.Equals(b), true);
        }
    }
}
