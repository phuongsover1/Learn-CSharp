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

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object k in stuff)
            {
                Console.WriteLine(k);
            }
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach(int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min; 
        }
    }
}
