using System;
using System.Collections.Generic;

namespace _10_polymorphism_
{
    class Program
    {
        public static void Main(string[] args)
        {
            // a car can be a BMW, an Audi, a Porsche etc,
            // Polymorphism at work #1: an Audi, BMW, Porsche
            // can all be used wherever a Car is expected. No cast is 
            // required because an implicit coversion exists from a derived 
            // class to its base class.
            List<Car> cars = new List<Car>()
            {
                new BMW("200", "blue", "A4"),
                new Audi("250", "red" , "M3")
            };
            foreach(Car car in cars)
            {
                car.Repair();
            }

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class.

            //BMW bmw = new BMW("200", "blue", "A3");
            //bmw.Repair();
            Audi audi = new Audi("200", "brown", "M2");
            audi.Repair();

            // use Audi base class method instead of Audi's method
            Car test = (Car)audi;
            test.Repair();


        }
    }
}
