using System;                 // Allows us to use basic C# functions like Console.WriteLine
using System.Text;            // Needed for using StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. Concatenate three strings ---
            string part1 = "Hello";                  // First part of the string
            string part2 = "beautiful";              // Second part of the string
            string part3 = "world!";                  // Third part of the string

            // Combine them into one full sentence
            string fullSentence = part1 + " " + part2 + " " + part3;
            Console.WriteLine("Concatenated String: " + fullSentence);

            // --- 2. Convert a string to uppercase ---
            string upperSentence = fullSentence.ToUpper(); // Converts all letters to uppercase
            Console.WriteLine("Uppercase String: " + upperSentence);

            // --- 3. Create a StringBuilder and build a paragraph ---
            StringBuilder paragraph = new StringBuilder(); // Creates an empty StringBuilder

            // Append sentences one at a time
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here comes the second sentence. ");
            paragraph.Append("Finally, this is the last sentence in our paragraph.");

            // Output the paragraph
            Console.WriteLine("Paragraph using StringBuilder:");
            Console.WriteLine(paragraph.ToString());

            // Keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}

