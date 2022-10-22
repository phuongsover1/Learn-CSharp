using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    internal class IEnumerableExample2
    {

        public static void Run()
        {
            CollectionSum(IEnumerableExample.GetCollection(1));
            CollectionSum(IEnumerableExample.GetCollection(2));
            CollectionSum(IEnumerableExample.GetCollection(3));
        }

        public static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable to store the sum of the numbers in anyCollection
            int sum = 0;
            // for each number in the collection passed to this method
            foreach(int num in anyCollection)
            {
                sum += num;
            }

            // print the sum
            Console.WriteLine($"Sum is {sum}");
        }

    }

}
