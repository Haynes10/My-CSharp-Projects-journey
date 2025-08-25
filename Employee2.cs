using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee2 : Person2, IQuittable
    {
        //We are now required to give our own version of SayName()
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //Prints the full name to the console
        }
        //Required method from IQuittable
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit the job. Time to find a replacement");
        }
    }
}

