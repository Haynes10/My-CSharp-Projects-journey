using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // This class has three methods that do different math operations
    public class MathOperations
    {
        // Multiply the input number by 5
        public int MultiplyByFive(int number)
        {
            return number * 5; // return the result
        }

        // Add 20 to the input number
        public int AddTwenty(int number)
        {
            return number + 20; // return the result
        }

        // Subtract 7 from the input number
        public int SubtractSeven(int number)
        {
            return number - 7; // return the result
        }
    }
}

