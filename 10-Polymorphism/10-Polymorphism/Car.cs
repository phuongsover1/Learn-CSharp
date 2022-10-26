using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_polymorphism_
{
    internal class Car
    {
        public string HP { get; set; }
        public string Color { get; set; }
        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int id, string owner)
        {
            carIDInfo.IDNum = id;
            carIDInfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has a ID of a {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public Car(string hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}"); 
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
