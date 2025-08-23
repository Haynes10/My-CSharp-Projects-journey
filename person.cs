using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    public class Person
    {
        //Property to hold the first and last name of the person.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Method that displays the full name of the person to the console
        //No parameters are needed because it uses the properties above
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
