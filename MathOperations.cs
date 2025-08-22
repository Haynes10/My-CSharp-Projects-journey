using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodsAssignment
{
    // This class has three methods that do different math operations
    public class MathOperations
    {
        //First Method: Takes in an integer, adds 12 to it, and returns the result
        public int DoMath(int number)
        {
            return number + 12; //Simple Addition
        }

        //Second Method: Takes in a decimal, multiplies it by 3, and returns the result as an integer
        public int DoMath(decimal number)
        {
            return (int)(number * 3); //Convert to int after mutliplying
        }

        //Third Method: Takes in a string, converts it to an integer, subtracts 6, and return the result
        public int DoMath(string numberString)
        {
            //Convert the string to an integer safely
            int convertedNumber = Convert.ToInt32(numberString);

            //Do a different math operation (subtraction)
            return convertedNumber - 6;
        }
    }
}


