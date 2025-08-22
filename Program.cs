using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with name
            Employee employee = new Employee();
            {
                employee.FirstName = "Mike";
                employee.LastName = "Tyson";
                employee.Id = 1234;
            }
            // Call to SayName method from the Person class on the Employee object
            //Because Employee inherits from Person, this work perfectly
            employee.SayName();
            Console.ReadLine();
        }
    }
}
