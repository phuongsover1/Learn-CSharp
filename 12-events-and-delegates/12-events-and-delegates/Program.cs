using System;
namespace _12_events_and_delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            // list of name 
            List<string> names = new List<string>()
            { "Aiden", "Sif",
                "Walter", "Anatoli" };

            names.RemoveAll(Filter);
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }


        }

        // a method called filter that takes a string
        static bool Filter(string s)
        {
            // return whether the string s contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains('i');
        }
    }
}
