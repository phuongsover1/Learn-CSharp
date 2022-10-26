using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_polymorphism_
{
    internal abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume(); 

    }
}
