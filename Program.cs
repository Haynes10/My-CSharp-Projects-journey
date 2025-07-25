using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the program header
            Console.WriteLine("Anonymous Income Comparison Program");

            // === Person 1 ===
            Console.WriteLine("\nPerson 1"); // Start of Person 1 section
            Console.Write("Hourly Rate? ");
            string rate1Input = Console.ReadLine(); // Get hourly rate as string
            int hourlyRate1 = Convert.ToInt32(rate1Input); // Convert to int

            Console.Write("Hours worked per week? ");
            string hours1Input = Console.ReadLine(); // Get hours worked
            int hoursWorked1 = Convert.ToInt32(hours1Input);

            // === Person 2 ===
            Console.WriteLine("\nPerson 2"); // Start of Person 2 section
            Console.Write("Hourly Rate? ");
            string rate2Input = Console.ReadLine(); // Get hourly rate
            int hourlyRate2 = Convert.ToInt32(rate2Input);

            Console.Write("Hours worked per week? ");
            string hours2Input = Console.ReadLine(); // Get hours worked
            int hoursWorked2 = Convert.ToInt32(hours2Input);

            // === Calculate Annual Salary ===
            int annualSalary1 = hourlyRate1 * hoursWorked1 * 52; // Salary for Person 1
            int annualSalary2 = hourlyRate2 * hoursWorked2 * 52; // Salary for Person 2

            // === Output Results ===
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1); // Display Person 1 salary

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2); // Display Person 2 salary

            // Compare salaries and show result
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2:");
            Console.WriteLine(person1MakesMore); // Display true or false

            // Wait for user before closing
            Console.ReadLine();
        }
    }
}

