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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EyeColor { get; private set; }
        public int Age { get; set; }


        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EyeColor = eyeColor;
            this.Age = age;
        }

        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // member 
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi my name is {0} {1} and {2} years old. My eye color is {3}",
                FirstName, LastName, Age, EyeColor);

        }


    }
}
