using System;

namespace _03function_and_methods_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //writesomething();
            //writesomethingspecific("i am an argument and am called from a method");
            int result = Add(15, 31);
            Console.WriteLine(result);

            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));


            Console.WriteLine("Devide: {0}", Devide(3, 4));

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(int num1, int num2)
        {
            return num1 / (double)num2;
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
