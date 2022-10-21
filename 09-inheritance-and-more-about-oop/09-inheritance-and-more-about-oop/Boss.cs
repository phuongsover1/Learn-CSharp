using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {
            CompanyCar = "no company car";
        }

        public Boss(string name, string firstName, float salary, string companyCar):base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} {1} is leading!", Name, FirstName);
        }

       
    }
}
