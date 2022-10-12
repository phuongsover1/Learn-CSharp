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
            Console.WriteLine("int: {0}, long: {1}, double: {2}", num, bigNum, bigDouble);

            // typeConversion
            string myString = bigDouble.ToString();
            string myString1 = myDouble.ToString();
            Console.WriteLine("myString: {0}, myString1: {1}", myString, myString1);

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine("myBoolString: " + myBoolString);
        }
    }
}
