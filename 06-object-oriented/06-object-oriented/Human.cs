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
        public string  firstName;

        // member 
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi my name is {0}", firstName);

        }

    }
}
