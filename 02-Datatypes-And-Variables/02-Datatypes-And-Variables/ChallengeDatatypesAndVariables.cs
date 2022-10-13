using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class ChallengeDatatypesAndVariables
    {
        public static void Main(string[] args)
        {
            /*
             *Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitivedatatypes(you can find the list here). Leave the Object datatype out.
              And also please initialize each variable with a working value.

              Then create two values of type string.
              The first one should say "I control text"
              
              The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.
              
              Add each an output for each of the variables and write it onto the console. (WriteLine)
              Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
              Have fun:) 
             * 
             * 
             */
            byte byteNumber = 21;// 0 to 255
            sbyte sbyteNumber = -127;// 0127 to 127
            int intNumber = 123; // 
            uint uintNumber = 323;
            short shortNumber = 323;
            ushort ushortNumber = 3232;
            long longNumber = 32323829382938;
            ulong ulongNumber = 3829839283923892892;
            float floatNumber = 32.3232f;
            double doubleNumber = 4343.4343;
            char character = ' ';
            bool boolValue = true;
            decimal decimalNumber = 43434.434334M;

            string firstString = "I control text";
            string numberInStr = "3434.43";
            float parsedNumber = float.Parse(numberInStr);
            Console.Write("parsedNumber:{0}", parsedNumber);
        }
    }
}
