using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParsingEnumsApp
{
    class Program
    {
        // Enum for all days of the week. This lets us treat days as named values instead of just strings.
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Greet the user
            Console.WriteLine("Hey there! Let's figure out what day of the week it is.");

            // Loop until user gives a valid day
            bool validDayEntered = false; // we'll use this to keep asking until input is correct
            while (!validDayEntered)
            {
                // Ask the user to type in a day
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                try
                {
                    // Try to convert what they typed into our enum
                    // The 'true' parameter ignores case so "monday" works too
                    if (Enum.TryParse(userInput, true, out DayOfWeek day))
                    {
                        // Success! Show the user what they typed
                        Console.WriteLine($"Perfect! You entered: {day}");
                        validDayEntered = true; // exit the loop
                    }
                    else
                    {
                        // The input didn't match any enum value
                        Console.WriteLine("Oops! That doesn't look like a day of the week. Try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Just in case something weird happens
                    Console.WriteLine($"Something went wrong: {ex.Message}");
                }
            }

            // Friendly closing message
            Console.WriteLine("Thanks for using the Day Parser! Program finished.");
            Console.ReadLine(); // keeps the console open so the user can see the result
        }
    }
}

