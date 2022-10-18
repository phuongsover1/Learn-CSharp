using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class _Dictionary
    {
        public static void Run()
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwym", 95),
                new Employee("Manager", "Joe", 35),
                new Employee("HR", "Lora", 32),
                new Employee("Secretary", "Petra", 28),
                new Employee("Lead Developer", "Artorias", 55),
                new Employee("Intern", "Ernest", 22)
            };

            Dictionary<string, Employee> myDictionary = new Dictionary<string, Employee>();

            foreach(Employee e in employees)
            {
                myDictionary.Add(e.Role, e);
            }

            Employee ceo = myDictionary["CEO"];
            Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", ceo.Name, ceo.Role, ceo.Salary);




        }
    }
    class Employee
    {
        public string Role { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Rate { get; set; }
        
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // simple constructor
        public Employee(string role, string name, int age)
        {
            Role = role;
            Name = name;
            Age = age;
        }
    }
}
