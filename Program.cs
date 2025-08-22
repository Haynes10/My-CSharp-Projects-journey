using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the MathOperations Class
            MathOperations math = new MathOperations();

            //Call the first method (int)
            int intResult = math.DoMath(15);
            Console.WriteLine("Result of integer method (15 + 12): " + intResult);

            //Call the second method (decimal)
            int decimalResult = math.DoMath(7.5m);
            Console.WriteLine("Result of decimal method (7.5 * 3): " + decimalResult);

            //Call the third method (string)
            int stringResult = math.DoMath("23");
            Console.WriteLine("Result of string method (23 - 6): " + stringResult);

            //Keep the console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}




