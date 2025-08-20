using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Console App that demonstrates arrays, loops, lists, user input, and duplicate checking


        // ------------------- Part 1 -------------------
        // One-dimensional array of strings representing snacks
        string[] snacks = { "Pizza", "Burgers", "Tacos", "Fries" };

        // Ask the user to add some text to all the snacks
        Console.WriteLine("Part 1: What would you like to add to these snacks?");
        string userInput = Console.ReadLine();

        // Loop through each snack and append the user's input
        for (int i = 0; i < snacks.Length; i++)
        {
            snacks[i] += " with " + userInput; // Update the array element
        }

        // Print each updated snack
        Console.WriteLine("\nHere are your updated snacks:");
        foreach (string food in snacks)
        {
            Console.WriteLine(food); // Display each snack on its own line
        }

        // Pause before moving to next part
        Console.ReadLine();

        // ------------------- Part 2 -------------------
        // Demonstrate an "infinite" loop that we safely stop
        Console.WriteLine("\nPart 2: Fixed Infinite Loop");
        int counter = 0;

        // This loop looks infinite because 'true' is always true
        while (true)
        {
            Console.WriteLine("Counter: " + counter); // Print the current counter
            counter++; // Increment counter each iteration

            // Break condition to stop the loop after 6 iterations
            if (counter > 5)
            {
                Console.WriteLine("Loop stopped before going infinite.");
                break; // Stop the loop
            }
        }

        // ------------------- Part 3 -------------------
        // Loop using '<' operator
        Console.WriteLine("\nPart 3: Loop using '<' operator");
        for (int i = 0; i < 5; i++) // Loops while i is less than 5
        {
            Console.WriteLine("i is " + i); // Print the current value of i
        }

        // Loop using '<=' operator
        Console.WriteLine("\nPart 3: Loop using '<=' operator");
        for (int i = 0; i <= 5; i++) // Loops while i is less than or equal to 5
        {
            Console.WriteLine("i is " + i); // Print the current value of i
        }

        // ------------------- Part 4 -------------------
        // List of unique fruits
        List<string> fruits = new List<string>() { "Apple", "Banana", "Orange", "Grapes" };

        // Ask the user to search for a fruit
        Console.WriteLine("\nPart 4: Enter a fruit to search for:");
        string searchInput = Console.ReadLine();

        bool found = false; // Flag to track if fruit is found

        // Loop through the list and check for a match
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i].ToLower() == searchInput.ToLower()) // Case-insensitive comparison
            {
                Console.WriteLine($"Found \"{searchInput}\" at index {i}"); // Print index if found
                found = true;
                break; // Stop loop after first match
            }
        }

        // Inform user if fruit was not found
        if (!found)
        {
            Console.WriteLine($"Sorry, \"{searchInput}\" is not on the list.");
        }

        // ------------------- Part 5 -------------------
        // List of colors with duplicates
        List<string> colors = new List<string>() { "Red", "Blue", "Green", "Blue", "Yellow" };

        // Ask the user to search for a color
        Console.WriteLine("\nPart 5: Enter a color to search for (duplicates allowed):");
        string colorInput = Console.ReadLine();

        bool foundColor = false; // Flag to track if color is found

        // Loop through the list and print all matching indices
        for (int i = 0; i < colors.Count; i++)
        {
            if (colors[i].ToLower() == colorInput.ToLower()) // Case-insensitive comparison
            {
                Console.WriteLine($"Found \"{colorInput}\" at index {i}"); // Print each match
                foundColor = true; // Mark that at least one match was found
                // NO break here, because we want all matches
            }
        }

        // If no matches, inform the user
        if (!foundColor)
        {
            Console.WriteLine($"Sorry, \"{colorInput}\" is not on the list.");
        }

        // ------------------- Part 6 -------------------
        // List of animals with at least one duplicate
        List<string> animals = new List<string>() { "Dog", "Cat", "Bird", "Dog", "Fish" };

        Console.WriteLine("\nPart 6: Check which animals are unique or duplicates");

        // HashSet to track items we've already seen
        HashSet<string> seenAnimals = new HashSet<string>();

        // Foreach loop to evaluate each animal in the list
        foreach (string animal in animals)
        {
            if (seenAnimals.Contains(animal))
            {
                // Item already seen → duplicate
                Console.WriteLine($"{animal} - this item is a duplicate");
            }
            else
            {
                // Item not seen → unique
                Console.WriteLine($"{animal} - this item is unique");
                seenAnimals.Add(animal); // Add to set for future comparisons
            }
        }

        // Keep the console open so user can see results
        Console.ReadLine();
    }
}
