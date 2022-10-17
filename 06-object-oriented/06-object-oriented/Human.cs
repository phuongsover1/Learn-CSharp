using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_object_oriented
{
    // this calss is a blueprint for a datatype
    internal class Human
    {
        // member variable
        string  firstName;
        string lastName;

        // constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member 
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi my name is {0} {1}", firstName, lastName);

        }

    }
}
