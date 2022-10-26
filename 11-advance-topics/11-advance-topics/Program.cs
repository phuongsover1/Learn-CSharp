using System;
namespace _11_advance_topics
{
    class Program
    {

        public static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;

            Day a = Day.Fri;
            if (a == fr)
            {
                Console.WriteLine("Equal!");
            }
            // print the int value
            Console.WriteLine((int)Day.Fri);
        }
    }
}
