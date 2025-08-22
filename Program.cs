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

            //polymorphism: we can treat "employee" as IQuittable type since its implements that interface
            IQuittable quittableEmployee2 = employee2;

            //Call Quit() using the interface version
            quittableEmployee2.Quit();

            Console.ReadLine(); //Make the conosle not close right away

        }
    }
}
