using System;
using System.Collections.Generic;

namespace _10_polymorphism_
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Example 1 - reading Text
            string text = System.IO.File.ReadAllText(@"D:\C#\LearnC#\10-Polymorphism\10-Polymorphism\TextFile.txt");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"D:\C#\LearnC#\10-Polymorphism\10-Polymorphism\TextFile.txt");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
