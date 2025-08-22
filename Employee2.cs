using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee2 : Person2
    {
        //We are now required to give our own version of SayName()
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //Prints the full name to the console
        }
    }
}

