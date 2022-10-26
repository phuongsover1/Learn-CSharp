using System;
using System.Collections.Generic;
using System.IO;

namespace _10_polymorphism_
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = { "first line", "second line", "third line" };
            File.WriteAllLines(@"D:\C#\LearnC#\10-Polymorphism\10-Polymorphism\TextFileWrite.txt", lines);

            
        }
    }
}
