using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class Foreach
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[10];


            for (int i = 1; i <= nums.Length; ++i)
            {
                nums[i - 1] = i;
            }

            foreach(int k in nums)
            {
                Console.WriteLine(k);
            }
        }
    }
}
