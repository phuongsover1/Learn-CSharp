using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            // all dogs are happy
            IsHappy = true;
        }

        // simple override of the virtual method Eat
        public override void Eat()
        {
            // to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        // override of the virtual method MakeSound
        public override void MakeSound()
        {
            // since every animal will make a tottaly different sound
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuuf!.");
        }

        // override of the virtual method Play
        public override void Play()
        {
            // check if the dog is happy if yes call the Play method from the base class
            if (IsHappy)
            {
                base.Play();
                MakeSound();
            }
        }
    }
}
