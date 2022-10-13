using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class Challenge_String_and_its_methods
    {
        public static void Main(string[] args)
        {
            /*
             *Challenge 1 String and its methods

            Now you know the use of various string functions so lets create a small Console application to practice this.

            Declare a string variable and dont assign any value to it.

            Print on the console Please enter your name and press enter. You can then enter your name or any other valid string like tutorials.eu.

            Assign that entered string to the string variable which you have declared initially.

            The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line.
            
            In the third line, it writes on the console the string with no trailing or preceding white space like if string entered as tutorials.eu it should be written on the console as tutorials.eu.
            
            And in the last line, it should write the Substring of the entered string on the console.

            These kinds of features are e.g. used when creating a login screen, where the system will cut out trailing or preceding white space or, doesnt care about the casing of the entered username. 
             * 
             * 
             */

            string myStr;
            Console.Write("Please enter your name and press enter:");
            myStr = Console.ReadLine();
            Console.WriteLine("String Uppercase:" + myStr.ToUpper());
            Console.WriteLine("String Lowercase:{0}", myStr.ToLower());
            Console.WriteLine("Trimmed String:{0}", myStr.Trim());
            Console.WriteLine("My last name:{0}", myStr.Trim().Substring(myStr.Trim().IndexOf(" ") + 1)); ;


        }
    }
}
