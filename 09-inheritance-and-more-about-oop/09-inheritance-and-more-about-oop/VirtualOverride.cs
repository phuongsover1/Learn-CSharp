using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    // name, age, isHungry
    // makeSound,eat,play
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            // in our case all our animals are hungry by default
            IsHungry = true;
        }

        // an empty virtual method MakeSound for sub classes to override
        public virtual void MakeSound()
        {
            
        }


        // a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            //  check ì aninmal is hungry
            if (IsHungry)
            {
                // if yes then print the name of the anima + "is eating"
                Console.WriteLine($"{Name} is eating");
            } else
            {
                // otherwise print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }

        }

        // virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
