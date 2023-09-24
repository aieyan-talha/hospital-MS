using System;
namespace HospitalManagementSystem.Users
{
    public class Admin: User
    {
        private Doctor[] doctors;
        private Patient[] patients;

        public Admin(string name, string address, string email, uint phone) : base(name,address,email,phone)
        {
            type = UserType.Admin;
        }
    }
}
