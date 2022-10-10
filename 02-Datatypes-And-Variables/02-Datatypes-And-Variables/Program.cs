using System;
namespace DatatypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
           // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;

            // declaring and initializing a variable in one go
            int num2 = 23;
            int sum = num1 + num2; 

            // using concatination
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

        }
    }
} 
