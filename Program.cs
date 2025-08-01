using System;

class Program
{
    static void Main()
    {
        // Start of the program – greet the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask user for package weight
        Console.Write("Please enter the package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // If the package is too heavy, exit early
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Ask for width
            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            // Ask for height
            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            // Ask for length
            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Add up dimensions to check if the package is oversized
            int dimensionSum = width + height + length;

            // Handle if the dimensions are too large
            if (dimensionSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            // Bonus: Check if user entered something weird like zero or negative numbers
            else if (width <= 0 || height <= 0 || length <= 0)
            {
                Console.WriteLine("Oops! Dimensions must be greater than zero.");
            }
            else
            {
                // If all checks pass, calculate shipping quote
                int volume = width * height * length;
                decimal quote = (volume * weight) / 100m;

                // Show final price formatted like real money
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
                Console.WriteLine("Thank you!");
            }
        }
    }
}
