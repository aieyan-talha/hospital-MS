using System;
using HospitalManagementSystem.Utils;

namespace HospitalManagementSystem.Users
{
    public enum UserType
    {
        Doctor,
        Admin,
        Patient
    }

    public class User
    {
        protected int ID;
        protected string password;
        protected string name;
        protected string address;
        protected string email;
        protected uint phone;
        protected string gender;
        protected int age;

        protected UserType type;

        public User(string name, string address, string email, uint phone)
        {
            Random random = new Random();
            int randomId = random.Next(10000, 99999999);

            // Need to check if ID is not already being used
            this.ID = randomId;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("Full Name : {0}",name);
            Console.WriteLine("Address : {0}", address);
            Console.WriteLine("Email : {0}", email);
            Console.WriteLine("Phone : {0}", phone);
            Console.WriteLine("Gender : {0}", gender);
            Console.WriteLine("Age : {0}", age);

        }
    }
}
