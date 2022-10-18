using System;

namespace _09_inheritance_and_more_about_oop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOff();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "samsung");

            myTV.SwitchOn();
            myTV.WatchTV();
        }
        
    }
}
