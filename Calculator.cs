using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment
{
    public class Calculator
    {
        //Method that takes two integers, but the second one is optional
        //If the user doesn't provide the second number, it defaults to 7
        public int AddNumbers(int firstNumber, int secondNumber = 7)
        {
            //Just doing a simple math operation (Addition)
            return firstNumber + secondNumber;
        }
    }
}
