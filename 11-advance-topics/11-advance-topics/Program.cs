using System;
namespace _11_advance_topics
{
    class Program
    {

        public static void Main(string[] args)
        {
            Nullable<Int32> nullableInt = null;
            int? num1 = 1;
            double? num2 = new Double?();
            bool? boolValue = null;
            Console.WriteLine("{0}, {1}, {2}", num1, num2, boolValue);
            
        }


    }
}
