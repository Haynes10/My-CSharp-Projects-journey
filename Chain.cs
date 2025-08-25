using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Chain
    {
        // Auto-properties for Name and Num
        public string Name { get; set; }
        public float Num { get; set; }

        // Constructor if only a number is provided
        public Chain(float num) : this(num, "Rolly")
        {
            // This runs after calling the two-parameter constructor
            Console.WriteLine($"{Num} and your default name is {Name}");
        }

        // Constructor if only a name is provided
        public Chain(string name) : this(42, name)
        {
            // This runs after calling the two-parameter constructor
            Console.WriteLine($"{Name} and your default favorite number is {Num}");
        }

        // Constructor if both a number and name are provided
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }
    }
}
