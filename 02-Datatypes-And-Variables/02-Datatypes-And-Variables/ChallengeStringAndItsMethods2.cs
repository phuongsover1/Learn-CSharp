using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Datatypes_And_Variables
{
    internal class ChallengeStringAndItsMethods2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string here:");
            string aString = Console.ReadLine();
            Console.Write("Enter a string you want to search in the previous typed string:");

            string wantToSearchString = Console.ReadLine();
            Console.WriteLine("The index of the first occurrence of the searched character from string:{0}", aString.IndexOf(wantToSearchString));

            Console.Write("Enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name:");
            string lastName = Console.ReadLine();
            string fullName = String.Concat(firstName, " ", lastName);
        }
    }
}
