using System;
using System.Collections.Generic;

namespace _10_polymorphism_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Sphere(3),
                new Cube(4)
            };
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();

                Cube cube = shape as Cube;
                if (cube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This is a cube!");
                }
            }



        }
    }
}
