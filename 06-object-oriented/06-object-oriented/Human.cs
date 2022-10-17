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
        private string  firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member 
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi my name is {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age,eyeColor);

        }

    }
}
