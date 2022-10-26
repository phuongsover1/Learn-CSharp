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

            Car bmw = cars[0];
            Car audi = cars[1];

            bmw.SetCarIDInfo(1234, "Phuong");
            audi.SetCarIDInfo(4567, "Khang");
            bmw.GetCarIDInfo();
            audi.GetCarIDInfo();


        }
    }
}
