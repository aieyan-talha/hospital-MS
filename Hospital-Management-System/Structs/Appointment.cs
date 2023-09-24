using System;
namespace HospitalManagementSystem.Structs
{
    public struct Appointment
    {
        public string title;
        public string location;
        public string description;
        public DateTime startTime;
        public DateTime endTime;

        public Appointment(string title, string location, string desc, DateTime start, DateTime end)
        {
            this.title = title;
            this.location = location;
            this.description = desc;
            this.startTime = start;
            this.endTime = end;
        }

    }
}
