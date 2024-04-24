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
        public int ScheduleID { get; set; }
        public Request RequestBased { get; private set; }
        public Account Tutor { get; private set; }
        public string ScheduleDescription {  get; private set; }
        public string ScheduleLocation { get; private set; }
        public DateTime ScheduleDay { get; private set; }
        public DateTime ScheduleTimeStart { get; private set; }
        public DateTime ScheduleTimeEnd { get; private set; }
        public int TutoredSubject { get; private set; }
        public List<Account> Tutees { get; private set; }
        public string Remarks { get; private set; }
        public ScheduleStatus ScheduleStatus { get; private set; }

        public Schedule(int scheduleID, Request request, Account tutor, string description, string scheduleLocation, DateTime scheduleDay, DateTime scheduleTimeStart, DateTime scheduleTimeEnd, int tutoredSubject, List<Account> tutees, string remarks, ScheduleStatus sStatus)
        {
            this.ScheduleID = scheduleID;
            this.RequestBased = request;
            this.Tutor = tutor;
            this.ScheduleDescription = description;
            this.ScheduleLocation = scheduleLocation;
            this.ScheduleDay = scheduleDay;
            this.ScheduleTimeStart = scheduleTimeStart;
            this.ScheduleTimeEnd = scheduleTimeEnd;
            this.TutoredSubject = tutoredSubject;
            this.Tutees = tutees;
            this.Remarks = remarks;
            this.ScheduleStatus = sStatus;
        }

        public Schedule(Request request, Account tutor, string description, string scheduleLocation, DateTime scheduleDay, DateTime scheduleTimeStart, DateTime scheduleTimeEnd, int tutoredSubject, List<Account> tutees, string remarks)
        {
            this.RequestBased = request;
            this.Tutor = tutor;
            this.ScheduleDescription = description;
            this.ScheduleLocation = scheduleLocation;
            this.ScheduleDay = scheduleDay;
            this.ScheduleTimeStart = scheduleTimeStart;
            this.ScheduleTimeEnd = scheduleTimeEnd;
            this.TutoredSubject = tutoredSubject;
            this.Tutees = tutees;
            this.Remarks = remarks;
            this.ScheduleStatus = ScheduleStatus.Pending;
        }
    }
}
