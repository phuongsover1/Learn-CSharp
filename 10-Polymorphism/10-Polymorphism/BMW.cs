using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_polymorphism_
{
    // a BMW is a car 
    internal class BMW : Car
    {
        public string Model { get; set; }
        private string brand = "BMW";


        public BMW(string hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}, Model: {Model}");
        }

        public sealed override void Repair()
        {
            Console.WriteLine("BMW was repaired!");
        }

    }
}
