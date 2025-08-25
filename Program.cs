using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age and handle input safely
            try
            {
                // Prompt the user to enter their age
                Console.Write("Please enter your age: ");

                // Read input from console and attempt to convert it into an integer
                int age = Convert.ToInt32(Console.ReadLine());

                // Check if the user entered zero or a negative number
                if (age <= 0)
                {
                    Console.WriteLine("Error: Age must be greater than zero. Please try again with a valid number.");
                }
                // Check if the age is less than 18 (not allowed)
                else if (age < 18)
                {
                    Console.WriteLine("Error: You must be at least 18 years old to use this program.");
                }
                else
                {
                    // Get the current year from the system clock
                    int currentYear = DateTime.Now.Year;

                    // Calculate birth year by subtracting age from the current year
                    int birthYear = currentYear - age;

                    // Display the calculated birth year
                    Console.WriteLine($"You were born in approximately the year {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // If the user entered letters, symbols, or something that's not a number
                Console.WriteLine("Error: That was not a valid number. Please enter your age using digits only.");
            }
            catch (Exception)
            {
                // Catch any other unexpected errors
                Console.WriteLine("Oops! Something went wrong. Please try again later.");
                // Optionally show details for debugging (remove in production if not needed):
                // Console.WriteLine($"Debug info: {ex.Message}");
            }

            // Keep console window open until user presses Enter
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
