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
        public int RequestID { get; set; }
        public string RequestLocation { get; private set; }
        public DateTime RequestDay { get; private set; }
        public DateTime RequestTimeStart { get; private set; }
        public DateTime RequestTimeEnd { get; private set; }
        public int TutoredSubject { get; private set; }
        public List<Account> Tutees { get; private set; }
        public string Remarks { get; private set; }
        public RequestStatus RequestStatus { get; set; }

        public Request(string requestLocation, DateTime requestDay, DateTime requestTimeStart, DateTime requestTimeEnd, int tutoredSubject, List<Account> tutees, string remarks)
        {
            this.RequestLocation = requestLocation;
            this.RequestDay = requestDay;
            this.RequestTimeStart = requestTimeStart;
            this.RequestTimeEnd = requestTimeEnd;
            this.TutoredSubject = tutoredSubject;
            this.Tutees = tutees;
            this.Remarks = remarks;
            this.RequestStatus = RequestStatus.Pending;
        }

        public Request(int requestID, string requestLocation, DateTime requestDay, DateTime requestTimeStart, DateTime requestTimeEnd, int tutoredSubject, List<Account> tutees, string remarks, RequestStatus rStatus)
        {
            this.RequestID = requestID;
            this.RequestLocation = requestLocation;
            this.RequestDay = requestDay;
            this.RequestTimeStart = requestTimeStart;
            this.RequestTimeEnd = requestTimeEnd;
            this.TutoredSubject = tutoredSubject;
            this.Tutees = tutees;
            this.Remarks = remarks;
            this.RequestStatus = rStatus;
        }

        public override string ToString()
        {
            string r = "(" + this.RequestID + ")" + " Tutor Request about ";

            switch(this.TutoredSubject)
            {
                case 1:
                    r += "Mathematics ";
                    break;
                case 2:
                    r += "Computer Science ";
                    break ;
                case 3:
                    r += "Calculus ";
                    break;
                case 4:
                    r += "Physics ";
                    break;
                default:
                    break;
            }

            r += "at " + this.RequestLocation + "\n";
            r += "Date: " + this.RequestDay.ToString("dddd, MMM dd") + " (" + this.RequestTimeStart.ToString("hh:mm:tt") + "-" + this.RequestTimeEnd.ToString("hh:mm:tt") + ")";
            return r;
        }
    }
}
