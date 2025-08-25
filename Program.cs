using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to type in a number
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine(); // store the input as text (string)

            // Convert the string input into an integer
            int number = Convert.ToInt32(userInput);

            // Use the full file path where the number will be saved
            string filePath = @"C:\Users\caron\Logs\log.txt";

            // Write the number into the text file
            File.WriteAllText(filePath, number.ToString());

            // Read the text file back
            string fileContents = File.ReadAllText(filePath);

            // Show the contents of the file to the user
            Console.WriteLine("The number in the text file is: " + fileContents);

            // Keep console open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

