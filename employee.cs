using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjects
{
    //employee inherits from person, meaning it has all the properties and methods of Person
    public class Employee : Person
    {
        //Additional property unique to employee, an Id number
        public int Id { get; set; }
        
    }
}
