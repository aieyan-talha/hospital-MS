using System;
using HospitalManagementSystem.Utils;

namespace HospitalManagementSystem.Pages
{
    public class PatientPage
    {
        public static void MainMenu(string username)
        {
            Printer print;

            print.PrintHeader("Patient Menu");
            Console.WriteLine("Welcome to DOTNET Hospital Management System {0}", username);

            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. List patient details");
            Console.WriteLine("2. List my doctor details");
            Console.WriteLine("3. List all appointments");
            Console.WriteLine("4. Book appointments");
            Console.WriteLine("5. Exit to login");
            Console.WriteLine("6. Exit System");

            Console.Write("Input Here : ");
            int userInput = print.GetValidInput(1, 6);
        }
    }
}
