using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    internal class Radio 
    {
        // boolean to determine the state of the Radio
        public bool IsOn { get; set; }

        // string for the brand the name of the radio
        public string Brand { get; set; }


        public Radio(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // switch off the radio
        public void SwitchOff()
        {
            IsOn = false;
        }

        // switch on the radio
        public void SwitchOn()
        {
            IsOn = true;
        }
        // method to listen to the radio

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            } else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }

    }
}
