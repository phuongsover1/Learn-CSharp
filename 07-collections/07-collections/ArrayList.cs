using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class _ArrayList
    {
        public static void Run()
        {
            // declaring an ArrayList with undefined amount ò object
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of object;
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37f);
            myArrayList.Add(10.3);
            myArrayList.Add(true);

            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if (obj is double)
                {
                    sum += (double)obj;
                }else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
