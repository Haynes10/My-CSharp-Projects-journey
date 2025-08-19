using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Create an array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask the user to pick an index
        Console.WriteLine("Pick an index (0 - 4) from the string array:");
        try
        {
            // Convert user input to integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Display the string at the chosen index
            Console.WriteLine("You picked: " + stringArray[stringIndex]);
        }
        catch
        {
            // If the index is invalid or input is wrong, show this message
            Console.WriteLine("That index doesn’t exist in the string array.");
        }

        Console.WriteLine(); // Add a blank line for readability


 
        // Create an array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to pick an index
        Console.WriteLine("Pick an index (0 - 4) from the integer array:");
        try
        {
            int intIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked: " + intArray[intIndex]);
        }
        catch
        {
            Console.WriteLine("That index doesn’t exist in the integer array.");
        }

        Console.WriteLine();



        // Create a list of strings
        List<string> stringList = new List<string>() { "Dog", "Cat", "Rabbit", "Parrot", "Hamster" };

        // Ask the user to pick an index
        Console.WriteLine("Pick an index (0 - 4) from the string list:");
        try
        {
            int listIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked: " + stringList[listIndex]);
        }
        catch
        {
            Console.WriteLine("That index doesn’t exist in the string list.");
        }

        // Pause program so console doesn’t close immediately
        Console.WriteLine("\nProgram finished. Press any key to exit...");
        Console.ReadKey();
    }
}
