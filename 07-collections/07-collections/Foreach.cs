using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class Foreach
    {
        //public static void Main(string[] args)
        //{
        //    //int[] nums = new int[10];


        //    //for (int i = 1; i <= nums.Length; ++i)
        //    //{
        //    //    nums[i - 1] = i;
        //    //}

        //    //foreach (int k in nums)
        //    //{
        //    //    Console.WriteLine(k);
        //    //}

        //    // Create an array with 5 of your best friends
        //    // Create a foreach loop which greets all of them

        //    string[] myfriends = { "Khang", "Long" , "Luu", "Quy", "Thinh"};
        //    foreach(string name in myfriends)
        //    {
        //        Greeting(name);
        //    }
        //}

        private static void Greeting(string name)
        {
            Console.WriteLine("Hi {0}, my friend!", name);
        }
    }
}
