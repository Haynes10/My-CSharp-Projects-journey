using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the MathOperations class
            MathOperations math = new MathOperations();

            // Ask the user to type a number
            Console.WriteLine("Hey! Enter a number to see some math magic:");
            int userInput = Convert.ToInt32(Console.ReadLine()); // convert input to integer

            // Call the MultiplyByFive method
            int multiplied = math.MultiplyByFive(userInput);
            Console.WriteLine("Your number multiplied by 5 is: " + multiplied);

            // Call the AddTwenty method
            int added = math.AddTwenty(userInput);
            Console.WriteLine("Your number plus 20 is: " + added);

            // Call the SubtractSeven method
            int subtracted = math.SubtractSeven(userInput);
            Console.WriteLine("Your number minus 7 is: " + subtracted);

            // Keep the console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


