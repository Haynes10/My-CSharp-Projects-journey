using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of integers
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        // Ask the user to enter a number to divide each list item by
        Console.WriteLine("Enter a number to divide each integer in the list by:");

        try
        {
            // Try converting the user input into an integer
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Loop through each number in the list
            foreach (int num in numbers)
            {
                // Divide each number by the user's input and display the result
                int result = num / userNumber;
                Console.WriteLine($"{num} divided by {userNumber} = {result}");
            }
        }
        catch (DivideByZeroException ex)
        {
            // This block will run if the user enters 0
            Console.WriteLine("Error: You cannot divide by zero!");
            Console.WriteLine($"System message: {ex.Message}");
        }
        catch (FormatException ex)
        {
            // This block will run if the user enters text or invalid input
            Console.WriteLine("Error: Please enter a valid whole number.");
            Console.WriteLine($"System message: {ex.Message}");
        }
        catch (Exception ex)
        {
            // This block will catch any other unexpected errors
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"System message: {ex.Message}");
        }
        finally
        {
            // This block always runs no matter what
            Console.WriteLine("The program has finished the try/catch block and continued execution.");
        }

        // End of program message
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
