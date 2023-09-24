using System;
using HospitalManagementSystem.Structs;

namespace HospitalManagementSystem.Users
{
    public class Doctor: User
    {
        private string department;
        private string specialty;
        private int medicalLicenseNum;
        Patient[] patients;
        Appointment[] appointments;

        public Doctor(string name, string address, string email, uint phone, string dept, string specialty, int MLN) : base(name, address, email, phone)
        {
            this.department = dept;
            this.specialty = specialty;
            this.medicalLicenseNum = MLN;
            type = UserType.Doctor;
        }
    }
}
