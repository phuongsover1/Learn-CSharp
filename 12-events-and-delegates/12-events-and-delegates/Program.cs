using System;
namespace _12_events_and_delegates
{
    class Program
    {
        // defining a delegate type called FilterDelegate that takes a person object and return a boolean
        public delegate bool FilterDelegate(Person p);
        public static void Main(string[] args)
        {
            // create 4 Person objects
            Person p1 = new Person("Aiden", 41);
            Person p2 = new Person("Sif", 69);
            Person p3 = new Person("Walter", 12);
            Person p4 = new Person("Anatoli", 25);

            // add the objects to a lsit called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);


            // here we created a new variable called filter of type FilterDelegate.
            // then we assigned an anonymous method to it instead of an already defined method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            }; // don't forget the ; at the end because we are declaring a variable
               // and assigning it's value at the same time just like int x = 3; for example

            DisplayPeople("Between 20 and 30:", people, filter);

            // passing anonymous callback as a argument of method
            DisplayPeople("All people", people, delegate (Person p) { return true; });
                


        }

        // a method to display the list of people that passes the filter condition
        // (returns true)
        // this method will take a title to be displayed, the list of people,
        // and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // print the title
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                // check if this person passes the filter
                if (filter(p))
                {
                    // print the person's name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        // =============== FILTERS ================
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age > 65;
        }

    }
}
