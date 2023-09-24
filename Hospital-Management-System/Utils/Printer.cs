using System;
namespace HospitalManagementSystem.Utils
{
    public struct Printer
    {
        public void PrintHeader(string location)
        {
            Console.Clear();
            string applicationHeader = "Hospital Management System";
            int screenWidth = Console.WindowWidth;

            int getSidePadding(string text)
            {
                int headerWidth = text.Length + 4;
                int sidePaddingLength = (screenWidth - headerWidth) / 2;

                return sidePaddingLength;
            }

            string borderDouble = new string('=', screenWidth);
            string borderSingle = new string('-', screenWidth);
            string mainSidePadding = new string(' ', getSidePadding(applicationHeader));
            string locationSidePadding = new string(' ', getSidePadding(location));

            Console.WriteLine(borderDouble);
            Console.WriteLine($"|{mainSidePadding}{applicationHeader}{mainSidePadding}|");
            Console.WriteLine(borderSingle);
            Console.WriteLine($"|{locationSidePadding}{location}{locationSidePadding}|");
            Console.WriteLine(borderDouble);
            
        }

        public void PrintLine(string input) {
            Console.WriteLine(input);
        }

        public int GetValidInput(int min, int max)
        {
            int userInput;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= min && userInput <= max)
                {
                    break;
                } else
                {
                    Console.WriteLine("Invalid Input. Please select a value between {0} and {1}", min, max);
                }
            }

            return userInput;
        }
    }
}
