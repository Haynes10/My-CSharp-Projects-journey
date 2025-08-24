using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of employees (at least 10)
            //Notice at least two of them are named "Rebecca"
            List<Employee> employees = new List<Employee>();
            {
                new Employee { Id = 1, FirstName = "Mike", LastName = "Tyson" };
                new Employee { Id = 2, FirstName = "Scottie", LastName = "Barnes" };
                new Employee { Id = 3, FirstName = "Rebecca", LastName = "Smith" };
                new Employee { Id = 4, FirstName = "Jason", LastName = "Domingo" };
                new Employee { Id = 5, FirstName = "Rebecca", LastName = "Smith" };
                new Employee { Id = 6, FirstName = "Joe", LastName = "Ramirez" };
                new Employee { Id = 7, FirstName = "Tony", LastName = "Parker" };
                new Employee { Id = 8, FirstName = "Patrick", LastName = "Mahomes" };
                new Employee { Id = 9, FirstName = "Taylor", LastName = "Swift" };
                new Employee { Id = 10, FirstName = "Rolly", LastName = "Perez" };

            }
            //Using foreach loop to find all "Rebecca"s
            List<Employee> rebeccasForeach = new List<Employee>();
            foreach (Employee emp in employees)
            {
                //Check if the employee's first name is "Rebecca"
                if (emp.FirstName == "Rebecca")
                {
                    rebeccasForeach.Add(emp);
                }
            }
            //Print the results
            Console.WriteLine("Employee named Rebecca (using foreach loop) :");
            foreach (var rebecca in rebeccasForeach)
            {
                Console.WriteLine("ID: " + rebecca.Id + ", Name: " + rebecca.FirstName + " " + rebecca.LastName);
            }
            Console.WriteLine(); // Blank line for spacing

            //Same thing but using a lambda expression
            List<Employee> rebeccaLambda = employees.Where(e => e.FirstName == "Rebecca").ToList();

            Console.WriteLine("Employees named Rebecca (using lambda):");
            foreach (var rebecca in rebeccaLambda)
            {
                Console.WriteLine("ID: " + rebecca.Id + ", Name: " + rebecca.FirstName + " " + rebecca.LastName);
            }
            Console.WriteLine();

            //Using Lambda to find employees with Id > 5
            List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();
            Console.WriteLine("Employees with ID greater than 5 (using lambda):");
            foreach (var emp in idGreaterThanFive)
            {
                Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine();
        }
    }
}
