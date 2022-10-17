using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_function_and_methods
{
    internal class TryAndCatch
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                bool exit = true;
                try
                {
                    Console.Write("Please enter the first number:");
                    string num1Input = Console.ReadLine();
                    int number1 = int.Parse(num1Input);

                    Console.Write("Please enter the second number:");
                    string num2Input = Console.ReadLine();
                    int number2 = int.Parse(num2Input);

                    Console.WriteLine("Result of num1/num2: {0}",Devide(number1, number2));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number!");
                    ClearConsole();
                    exit = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The value is too large or too small for int32.");
                    Console.WriteLine("Max value is {0}", int.MaxValue);
                    Console.WriteLine("Min value is {0}", int.MinValue);
                    ClearConsole();
                    exit = false;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    ClearConsole();
                    exit = false;
                }

                if (exit)
                    break;
            }


        }

        private static void ClearConsole()
        {
            Console.ReadKey();
            
            Console.Clear();
        }
        private static double Devide(int num1, int num2)
        {
            try
            {
                return num1 / (double)num2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Couldn't divide because number 2 is zero");
            }
        }
    }
}
