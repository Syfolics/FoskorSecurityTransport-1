using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoskorSecurityTransport.ViewModel
{
    public class TripViewModel
    {

        public float TripID { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public char StartingPoint { get; set; }
        public char Passenger1 { get; set; }
        public float CompanyNumber1 { get; set; }
        public char Destination1 { get; set; }
        public char Passenger2 { get; set; }
        public float CompanyNumber2 { get; set; }
        public char Destination2 { get; set; }
        public char Passenger3 { get; set; }
        public char CompanyNumber3 { get; set; }
        public char Destination3 { get; set; }
        public char Passenger4 { get; set; }
        public char CompanyNumber4 { get; set; }
        public char Destination4 { get; set; }
        public char Department1 { get; set; }
        public char Supervisor1 { get; set; }
        public char Reason { get; set; }
        public char Driver { get; set; }
        public char Vehicle { get; set; }
        public float KMOut { get; set; }
        public float KMIn { get; set; }
        public float TotalKMs { get; set; }
        public float TimeOut { get; set; }
        public float TimeIn { get; set; }
        public char Stat { get; set; }
        public DateTime SDateTime { get; set; }
        public char Capturer { get; set; }
        public char Supervisor2 { get; set; }
        public char Supervisor3 { get; set; }
        public char Supervisor4 { get; set; }
        public char Department2 { get; set; }
        public char Department3 { get; set; }
        public char Department4 { get; set; }
        public float noOfPassengers { get; set; }
    }
}