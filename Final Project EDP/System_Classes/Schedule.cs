using Final_Project_EDP.System_Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_EDP.System_Classes
{
    public class Schedule
    {
        public int ScheduleID { get; private set; }
        public string ScheduleLocation { get; private set; }
        public DateTime ScheduleDay { get; private set; }
        public DateTime ScheduleTimeStart { get; private set; }
        public DateTime RequestTimeEnd { get; private set; }
        public Tags TutoredSubject { get; private set; }
        public List<Account> Tutees { get; private set; }
        public string Remarks { get; private set; }
        public RequestStatus RequestStatus { get; private set; }
    }
}
