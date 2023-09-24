using System;
using HospitalManagementSystem.Users;
using HospitalManagementSystem.Utils;
using HospitalManagementSystem.Pages;

namespace HospitalManagementSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //User doctor = new User (name: "Dr Arshad", address: "Pakistan", phone: 03205501928, email: "arshad@gmail.com");

            Printer print;

            print.PrintHeader("Main Page");

            //PatientPage.MainMenu(); 
            Console.WriteLine("This is the hospital management system");
            Console.ReadKey();
        }
    }
}
