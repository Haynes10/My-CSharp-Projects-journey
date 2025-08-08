using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- WHILE LOOP -----

            // Use this variable to control our while loop
            int whileCounter = 1;

            // This while loop runs while whileCounter is less than or equal to 5
            Console.WriteLine("WHILE LOOP: Counting from 1 to 5...");
            while (whileCounter <= 5)
            {
                Console.WriteLine("Current number: " + whileCounter);

                // Add 1 to whileCounter every time the loop runs
                whileCounter++;
            }


            // ----- DO WHILE LOOP -----

            // Use this variable for our do while loop
            int doCounter = 6;

            // This do-while loop runs at least once, even if the condition is false
            Console.WriteLine("\nDO WHILE LOOP: Showing it runs at least once...");

            do
            {
                Console.WriteLine("This will print even though doCounter > 5. Current: " + doCounter);

                // Increment the counter
                doCounter++;
            }
            while (doCounter <= 5); // This is false right away, so loop ends after 1 run

            // Keeps the console window open so we can read the output
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

