using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class _Dictionary
    {
        public static void Run()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");

            // retrieve value through key
            Console.WriteLine(myDictionary[1]);

        }
    }
}
