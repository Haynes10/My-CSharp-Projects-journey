using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{

    using System;

    namespace StructAssignment
    {
        class Program
        {
            // Define a struct named Number
            // A struct is like a class but it's a value type instead of a reference type
            public struct Number
            {
                // Property "Amount" of type decimal (good for money or precise numbers)
                public decimal Amount { get; set; }
            }

            static void Main(string[] args)
            {
                // Create a new object of type Number
                Number myNumber = new Number();

                // Assign a value to the Amount property
                // I'm just using a random example amount, but this could be any decimal number
                myNumber.Amount = 123.45m;

                // Print the value of Amount to the console
                Console.WriteLine($"The amount stored in myNumber is: {myNumber.Amount}");

                // Keeps the console open so I can see the output before it closes
                Console.ReadLine();
            }
        }
    }
}

