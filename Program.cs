using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "Kai",
                    LastName = "Lopez",
                    EnrollmentDate = DateTime.Now
                };

                // Add student to the DbSet
                context.Students.Add(student);

                // Save to database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
