using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_polymorphism_
{
    internal class Audi : Car
    {
        public string Model { get; set; }
        private string brand = "Audi";

        public Audi(string hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}, Model: {Model}");
        }

        public new void Repair()
        {
            Console.WriteLine("Audi was repaired!");
        }

    }
}
