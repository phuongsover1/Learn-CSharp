using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IEnumerable_and_IEnumerator_
{
    class IEnumerableAndIEnumerator
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections 

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property that points at the object we are currently at in the collection.
        ///
        /// </summary>
        /// 

        // when it is recommended to use the IEnumerable interface:
        //  - Your collection represents a massive database table,
        // you don't want to copy the entire thing into memory and cause performance issues in your application.
        // when it is not recommended to use the IEnumerable interface:
        // - You need the results right away and are possibly mutating / editing the objects later on.
        // In this case, it is better to use an Array or a List.

        public static void Run()
        {
            DogShelter dogShelter = new DogShelter();
            foreach (Dog dog in dogShelter)
            {
                if (!dog.IsNaughtyDog)
                    dog.GiveTreat(3);
            }
        }

    }

    class Dog
    {
        // the name of the dog
        public string Name { get; set; }
        // is this a naught dog
        public bool IsNaughtyDog { get; set; }
        //simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        // this method will print how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            // print a message containing the number of treats and nthe name of the dog
            Console.WriteLine($"Dog: {Name} said wuoff {numberOfTreats} times!.");
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        // list of type List<Dog>
        public List<Dog> dogs;

        // this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


}
