using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    public class MathOperations2
    {
        //This is a void method, meaning it does not return anything
        //It accepts two integers as parameters
        //It performs a maht operation on the first ineteger and displays the second integer to the Console
        public void PerformOperation(int number1, int number2)
        {
            //Mulitply the first number by 4, just as an example math operation
            int result = number1 * 4;

            //Display the result of the math operation
            Console.WriteLine("The first number mulitplied by 4 is: " + result);

            //Display the second number that was passed in
            Console.WriteLine("The second number provided is: " + number2);
        }
    }
}
