using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    public class MathMethods
    {
        //Void method that takes an integer, divides it by 2, and prints the result
        public static void DivideByTwo(int number)
        {
            int result = number / 2; // Divide number by 2
            Console.WriteLine($"Your number divided by 2 is: {result}");
        }

        //Method with output parameters: returns sum and product of two numbers
        public static void Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        //Overloaded method: same name, but works with doubles instead of ints
        public static double DivideByTwo(double number)
        {
            return number / 2.0;
        }
    }
}
