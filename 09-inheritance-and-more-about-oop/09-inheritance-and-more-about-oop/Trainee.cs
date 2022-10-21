using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class Trainee : Employee
    {
        public float WorkingHours { get; set; }
        public float SchoolHours { get; set; }

        public Trainee()
        {
            WorkingHours = 0;
            SchoolHours = 0;
        }

        public Trainee(string name, string firstName, float salary, float workingHours, float schoolHours) : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} {1} is learning!", Name, FirstName);
            
        }

        public override void Work()
        {
            Console.WriteLine("{0} {1} is working in {2} hours!", Name, FirstName, WorkingHours);
        }
    }

}
