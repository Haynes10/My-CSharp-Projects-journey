using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
class Program
{
        static void Main(string[] args)
    {
            //Write a welcome messsage to make the console app look more complete
            Console.WriteLine("=== Welcome to the Void Method Assignment Demo ===\n");

            //Instantiate the MathOperations class so we can call its methods
            MathOperations2 mathOps = new MathOperations2();

            //First example: Call the method normally by just passing two integers
            Console.WriteLine("First call: passing two numbers directly ( 3 and 6).");
            mathOps.PerformOperation(3, 6);

            Console.WriteLine(); //Blank line for readability

            //Second example: Call the method but specify parameter name explicitly
            Console.WriteLine("Second call: using named parameter (number1: 8, number2: 22).");
            mathOps.PerformOperation(number1: 8, number2: 22);

            Console.WriteLine();

            //Adding a third call for variety and to test different inputs
            Console.WriteLine("Third call: another test with numbers: (10, 2).");
            mathOps.PerformOperation(10, 2);

            //Closing message so it feels like a real program 
            Console.WriteLine("\n=== End of Program. Press any key to exit. ===");
            Console.ReadKey(); //Keeps the console open until a key is pressed
        }
    }
}
