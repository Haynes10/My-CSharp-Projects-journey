using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new Employee object
            //Give it some values
            //Call the method to show the name
            Employee2 employee2 = new Employee2();
            employee2.FirstName = "Kobe";
            employee2.LastName = "Bryant";
            employee2.SayName();

            Console.ReadLine(); //Make the conosle not close right away

        }
    }
}
