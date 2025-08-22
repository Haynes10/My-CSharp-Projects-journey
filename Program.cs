using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the Calculator class
            Calculator calc = new Calculator();

            //Ask the user for the first number
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            //Convert the first number from string to int
            int number1 = Convert.ToInt32(input1);

            //Ask the users for the secod number (optional)
            Console.WriteLine("Enter the second number (or press Enter to skip):");
            string input2 = Console.ReadLine();

            int result;

            //If the user typed something, use both numbers
            if (!string.IsNullOrWhiteSpace(input2))
            {
                int number2 = Convert.ToInt32(input2); //Convert second number
                result = calc.AddNumbers(number1, number2); //Call method with both numbers
            }
            else
            {
                //If user skipped, just call method with one number (second defaults to 7)
                result = calc.AddNumbers(number1);
            }

            //Show the result
            Console.WriteLine("The Result is; " + result);

            //Pause so the console stays open
            Console.ReadLine();
        }
    }
}
