using System;
namespace DatatypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //// declaring a variable
            // int num1;
            // // assigning a value to a variable
            // num1 = 13;

            // // declaring and initializing a variable in one go
            // int num2 = 23;
            // int sum = num1 + num2; 

            // // using concatination
            // Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // // declaring multiple variables at once
            // int num3 = 3, num4 = 4, num5 = 5;
            // Console.WriteLine("num3: " + num3 + ", num4: " + num4+ ", num5: " + num5);


            // double d1 = 3.1415;
            // double d2 = 5.1;
            // double dDiv = d1 / d2;
            // Console.WriteLine("d1/d2 is " + dDiv);

            // float f1 = 3.2424f; // must have 'f' suffix when assign value to float type
            // float f2 = 5.1f;
            // Console.WriteLine("f1/f2: " + f1/f2);

            // double dIDiv = d1 / num1;
            // Console.WriteLine( "dIDiv" + dIDiv);

            // int dIdivInt = d1 / num1; // error because the result of this evaluation is double's type. Cannot implicitly cast to int.


            string myName = "Phuong";

            string message = "My name is " + myName;

            Console.WriteLine(message);

        }
    }
}
