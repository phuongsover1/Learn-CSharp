using System;
using System.Collections.Generic;
using System.IO;

namespace _10_polymorphism_
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = { "250", "240", "242" };
            File.WriteAllLines(@"D:\C#\LearnC#\10-Polymorphism\10-Polymorphism\TextFileWrite.txt", lines);

            string[] highScores = File.ReadAllLines(@"D:\C#\LearnC#\10-Polymorphism\10-Polymorphism\TextFileWrite.txt");
            foreach(string score in highScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
