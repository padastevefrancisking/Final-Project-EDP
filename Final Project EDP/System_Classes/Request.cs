using Final_Project_EDP.System_Enums;
using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_EDP.System_Classes
{
    public class Request
    {
        public int RequestID { get; private set; }
        public string RequestLocation { get; private set; }
        public DateTime RequestDay { get; private set; }
        public DateTime RequestTimeStart { get; private set; }
        public DateTime RequestTimeEnd { get; private set; }
        public Tags TutoredSubject { get; private set; }
        public List<Account> Tutees { get; private set; }
        public string Remarks { get; private set; }
        public RequestStatus RequestStatus { get; private set; }

        public Request(string requestLocation, DateTime requestDay, DateTime requestTimeStart, DateTime requestTimeEnd, Tags tutoredSubject, List<Account> tutees)
        {
            this.RequestLocation = requestLocation;
            this.RequestDay = requestDay;
            this.RequestTimeStart = requestTimeStart;
            this.RequestTimeEnd = requestTimeEnd;
            this.TutoredSubject = tutoredSubject;
            this.Remarks = string.Empty;
            this.RequestStatus = RequestStatus.Pending;
            this.Tutees = tutees;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Request))
                return false;

            if (obj is null)
                return false;

            Request c = (Request) (obj);
            return (c.RequestLocation == this.RequestLocation) && (c.RequestDay == this.RequestDay) && (c.RequestTimeStart == this.RequestTimeStart) && (c.TutoredSubject == this.TutoredSubject) && (c.Tutees == this.Tutees);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
