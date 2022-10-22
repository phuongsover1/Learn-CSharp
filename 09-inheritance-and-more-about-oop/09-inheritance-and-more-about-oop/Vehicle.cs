using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        // default constructor
        public Vehicle()
        {
            Speed = 0;
            Color = "default color";
        }

        // simple constructor 
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
