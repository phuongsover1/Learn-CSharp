using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class ElectricalDevice
    {
        // boolean to determine the state of the Radio
        public bool IsOn { get; set; }

        // string for the brand the name of the radio
        public string Brand { get; set; }


        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // switch off the device
        public void SwitchOff()
        {
            IsOn = false;
        }

        // switch on the device
        public void SwitchOn()
        {
            IsOn = true;
        }
        // method to listen to the device

        public void ListenToDevice()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the device!");
            } else
            {
                Console.WriteLine("Device is switched off, switch it on first");
            }
        }

    }
}
