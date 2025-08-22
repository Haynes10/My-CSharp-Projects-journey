using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Call the static method DivideByTwo (int version)
            MathMethods.DivideByTwo(userNumber);

            //Demonstrate method  Overloading(double version)
            double result = MathMethods.DivideByTwo(7.5);
            Console.WriteLine($"7.5 divided by 2 is: {result}");

            //Demonstrate method with output parameters
            int sum, product;
            MathMethods.Calculate(5, 10, out sum, out product);
            Console.WriteLine($"Using output parameters: Sum = {sum}, Product = {product}");

            //Pause so the console stays open
            Console.ReadLine();
        }
    }
}
