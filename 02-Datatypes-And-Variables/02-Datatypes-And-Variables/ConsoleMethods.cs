using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class ConsoleMethods
    {
/*        public static void Main(string[] args)
        {
            *//*            Console.Write("Enter a string and press enter:");
                        string readInput = Console.ReadLine();
                        Console.WriteLine("You have entered {0}", readInput);

                        Console.Write("Enter any key and press enter:");
                        int asciiValue = Console.Read();
                        Console.WriteLine("ASCII value is {0}:", asciiValue);
            *//*
            //ConsoleKeyInfo consoleKey = Console.ReadKey();
            //Console.WriteLine("consoleKey.KeyChar: {0}", consoleKey.KeyChar); 
            //Console.WriteLine("consoleKey.Key: {0}", consoleKey.); 

            ChangeConsoleColor();
        }
*/
        public static void ChangeConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Clear();

            Console.WriteLine("Hello Phuong");
            Console.WriteLine("C# is cool!");
        }
    }
}
