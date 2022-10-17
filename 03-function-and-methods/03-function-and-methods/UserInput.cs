using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_function_and_methods
{
    internal class UserInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
        }

        private static int Calculate()
        {
            Console.Write("Please enter the first number:");
            string number1Input = Console.ReadLine();
            Console.Write("Please enter the second number:");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            return num1 + num2;
        }
    }
}
