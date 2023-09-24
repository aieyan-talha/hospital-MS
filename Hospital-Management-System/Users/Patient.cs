using System;
using HospitalManagementSystem.Structs;

namespace HospitalManagementSystem.Users
{
    public class Patient : User
    {
        private int insuranceNumber;
        Doctor[] doctors;
        Appointment[] appointments;
        Medication[] medication;

        public Patient(string name, string address, string email, uint phone, int iNum) : base(name, address, email, phone)
        {
            this.insuranceNumber = iNum;
            type = UserType.Patient;

        }
    }
}
