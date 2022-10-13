using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class Challenge_String_and_its_methods
    {
/*        public static void Main(string[] args)
        {
            *//*
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

            /*            string mystr;
                        console.write("please enter your name and press enter:");
                        mystr = console.readline();
                        console.writeline("string uppercase:" + mystr.toupper());
                        console.writeline("string lowercase:{0}", mystr.tolower());
                        console.writeline("trimmed string:{0}", mystr.trim());
                        console.writeline("my last name:{0}", mystr.trim().substring(mystr.trim().indexof(" ") + 1)); ;*//*


            string myName;
            Console.Write("Please enter your name and press enter : ");
            myName = Console.ReadLine();
            string myUppercase = String.Format("Upper case:{0}", myName.ToUpper());
            string myLowercase = String.Format("Lower case:{0}", myName.ToLower());
            string myTrimmed = String.Format("Trimmed:{0}", myName.Trim());
            string myLastName = String.Format("My last name is:{0}", myTrimmed.Substring(myTrimmed.IndexOf(' ') + 1));
            string myFirstName = String.Format("My first name is:{0}", myTrimmed.Substring(0, myTrimmed.IndexOf(' ')));
            Console.WriteLine(myUppercase);
            Console.WriteLine(myLowercase);
            Console.WriteLine(myTrimmed);
            Console.WriteLine(myLastName);
            Console.WriteLine(myFirstName);
            

        }
*/    }
}
