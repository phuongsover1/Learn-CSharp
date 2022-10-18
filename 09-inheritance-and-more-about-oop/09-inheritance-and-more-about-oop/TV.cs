using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
     class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("The TV is turned off. Turn on the TV first!.");
            }
        }
    }
}
