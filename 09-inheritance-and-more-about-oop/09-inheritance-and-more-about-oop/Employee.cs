using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    /*
     * Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

Dont forget to create constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.

Just print out the respective text, what the respective employees do.
E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.
     * 
     */
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public float Salary { get; set; }

        public Employee()
        {
            Name = "anonymous";
            FirstName = "anonymous";
            Salary = 0;

        }

        public Employee(string name, string firstName, float salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work() { Console.WriteLine("{0} {1} is working!", Name, FirstName); }


        public virtual void Pause() { Console.WriteLine("{0} {1} is pausing1", Name, FirstName); }

        public static void Run()
        {
            Boss boss1 = new Boss("Phuong", "Nguyen", 5000, "Porcher");
            Trainee trainee1 = new Trainee("Hung", "Tran", 500, 20, 30);
            boss1.Lead();
            trainee1.Work();

        }

    }
} 