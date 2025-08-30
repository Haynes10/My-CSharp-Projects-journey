using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id { get; set; }   // Employee ID
        public string FirstName { get; set; }   // Employee first name
        public string LastName { get; set; }    // Employee last name

        // Overloading the == operator to compare Employee objects by Id
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id == right.Id; // If their Id is the same, they are equal
        }

        // Overloading the != operator to compare Employee objects by Id
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Id != right.Id; // If their Id is different, they are not equal
        }
    }
}
