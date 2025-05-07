using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class InputHandler
    {
        // Incomplete checking
        public string NameChecker()
        {
            Console.WriteLine("Enter the Name of the Student");
            String input = Console.ReadLine();
            return input;
        }
        // Check the Age 
        public int AgeChecker()
        {
            int value;
            while (true)
            {
                Console.WriteLine("Enter the Age of student");
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value; 
                }
                Console.WriteLine("Please Enter the Valid Age");
            }
        }
        // Phone number Checker
        public string PhoneChecker()
        {
            Console.WriteLine("Enter the Student Phone number");
            string input = Console.ReadLine();
            return input;
        }
        // Standard Checker
        public string StandardChecker()
        {
            Console.WriteLine("Enter the Standard");
            string input = Console.ReadLine();
            return input;
        }
    }
}
