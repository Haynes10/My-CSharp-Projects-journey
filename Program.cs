using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create const variables (unchangeable)
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is: ";

            // Prompt user for input
            Console.WriteLine("Enter your name or favorite number: ");

            // Create a variable using 'var' keyword (type inferred from input)
            var answer = Console.ReadLine();

            // Try parsing the answer as a number
            if (float.TryParse(answer, out float x))
            {
                // If it's a number, use the numeric constructor
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                // If it's not a number, treat it as a name
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}

