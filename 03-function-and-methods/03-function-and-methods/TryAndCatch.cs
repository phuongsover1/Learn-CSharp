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
            Console.WriteLine("Please enter a number!");
            try
            {
                string userInput = Console.ReadLine();
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The value is too large or too small for an int32. Maximum is {0} and minimum is {1}", int.MaxValue, int.MinValue);

            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

        }
    }
}
