using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person2
    {
        //Two properties every "Person" will have
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //This is just a "placeholder" method, forces child classes to fill it in
        public abstract void SayName();
    }

}
