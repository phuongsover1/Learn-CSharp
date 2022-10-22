using System;

namespace _09_inheritance_and_more_about_oop
{
    class Program
    {
        public static void Main(string[] args)
        {
            // creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            // add the two chairs to the IDestroyable list of the car
            // so that when we destroy  the car the destroyable obejcts 
            // that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // destroying the car 
            damagedCar.Destroy();
        }
        
    }
}
