using System;

namespace _09_inheritance_and_more_about_oop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Lu", 1);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
        
    }
}
