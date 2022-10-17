using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class JaggedArray
    {
        public static void Run()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[] {4,5,6};
            jaggedArray[2] = new int[] { 7, 8, 9 };

            foreach (int[] array in jaggedArray)
            {
                foreach(int i in array)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
