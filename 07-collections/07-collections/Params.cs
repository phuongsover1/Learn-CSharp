using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class Params
    {
        public static void ParamsMethod(params int[] numbers)
        {
            foreach(int k in numbers)
            {
                Console.WriteLine(k);
            }
        }
    }
}
