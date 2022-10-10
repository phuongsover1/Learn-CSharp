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

            // declaring multiple variables at once
            int num3 = 3, num4 = 4, num5 = 5;
            Console.WriteLine("num3: " + num3 + ", num4: " + num4+ ", num5: " + num5);


        }
    }
} 
