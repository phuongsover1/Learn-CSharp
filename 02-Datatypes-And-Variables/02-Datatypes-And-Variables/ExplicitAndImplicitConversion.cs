using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class ExplicitAndImplicitConversion
    {
        public static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            // cast double to int explicitly
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // implicit conversion
            int num = 12345432;
            long bigNum = num;

            double bigDouble = bigNum; 
        }
    }
}
