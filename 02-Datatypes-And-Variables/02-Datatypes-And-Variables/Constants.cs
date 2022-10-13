using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class Constants
    {
        // constants as fields
        const double PI = Math.PI;
        const int weeks = 52, month = 12;
        // Create a constant of type string with your birthday as its value
        const string myBirthday = "05/15/2001";
        public static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", myBirthday);


        }
    }
}
