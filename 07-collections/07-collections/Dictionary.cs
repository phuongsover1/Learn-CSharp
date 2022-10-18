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

            foreach (Employee e in employees)
            {
                myDictionary.Add(e.Role, e);
            }

            Employee ceo = myDictionary["CEO"];
            Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", ceo.Name, ceo.Role, ceo.Salary);


            // best practice when getting value from dictionary through key
            string key = "CTO";
            Employee employee = null;
            if (myDictionary.ContainsKey(key))
            {

                employee = myDictionary[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", employee.Name, employee.Role, employee.Salary);
            }

            // using TryGetValue() it returns true if the operation was successful and false otherwise
            //employee = null;
            //if (myDictionary.TryGetValue("Intern", out employee)) {
            //    Console.WriteLine("Value Retrieved!.");
            //    Console.WriteLine("Employee Name: {0}", employee.Name);
            //    Console.WriteLine("Employee Role: {0}", employee.Role);
            //    Console.WriteLine("Employee Age: {0}", employee.Age);
            //} else
            //{
            //    Console.WriteLine("The key does not exist");
            //}

            // another way to loop through dictionary
            for (int i = 0; i < myDictionary.Count; ++i)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = myDictionary.ElementAt(i);

                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);

                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name );
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
            }



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
