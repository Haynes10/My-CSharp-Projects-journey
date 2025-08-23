using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee and assign details
            Employee left = new Employee();
            left.Id = 101;
            left.FirstName = "Scottie";
            left.LastName = "Barnes";

            // Create second employee and assign details
            Employee right = new Employee();
            right.Id = 101;
            right.FirstName = "LeBron";
            right.LastName = "James";

            // Compare both employees using the overloaded operators
            Console.WriteLine("Do both employees have the same ID? " + (left == right));
            Console.WriteLine("Do both employees have different IDs? " + (left != right));

            Console.ReadLine(); // Keeps console open
        }
    }
}
