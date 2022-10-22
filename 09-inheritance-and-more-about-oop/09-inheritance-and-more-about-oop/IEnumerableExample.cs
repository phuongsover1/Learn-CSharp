using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    internal interface IEnumerableExample
    {
        public static void Run()
        {
            IEnumerable<int> unknowCollection;
            unknowCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            // foreach number in the collection we got back from GetCollection(1);
            foreach (int num in unknowCollection)
            {
                Console.Write(num + " ");
            }

            // new line 
            Console.WriteLine("");
            // call GetCollection() with option = 2 which will return a Queue<int>
            // but we will store it in the base type of generic collections
            unknowCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            // for each number in the collection we got back from GetCollection(2);
            foreach(int num in unknowCollection)
            {
                Console.Write(num + " ");
            }


            Console.WriteLine("");
            Console.WriteLine("This was a an array of int");
            unknowCollection = GetCollection(3);
            // for each number in the collection we got back from GetCollection(2);
            foreach(int num in unknowCollection)
            {
                Console.Write(num + " ");
            }
        }

        public static IEnumerable<int> GetCollection(int option)
        {
            // create a list of numbers and initialize it 
            List<int> numberLists = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            switch(option) {
                case 1:
                    return numberLists;
                case 2:
                    return numberQueue;
                default:
                    return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
