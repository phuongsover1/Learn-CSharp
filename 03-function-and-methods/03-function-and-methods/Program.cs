using System;

namespace _03function_and_methods_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteSomeThing();
            WriteSomethingSpecific("I am an argument and am called from a method");

        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomeThing()
        {
            Console.WriteLine("I am called from a method");
            
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
