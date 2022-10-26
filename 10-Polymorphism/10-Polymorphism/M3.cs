using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_polymorphism_
{
    internal class M3 : BMW
    {
        public M3(string hp, string color, string model):base(hp,color,model) { }

        public override void Repair() // error because Repair method in BMW was sealed
        {

        }
    }

}
