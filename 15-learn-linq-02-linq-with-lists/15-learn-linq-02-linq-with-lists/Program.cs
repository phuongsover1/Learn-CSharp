using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_learn_linq_02_linq_with_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();

            universityManager.MaleStudents();
            universityManager.FemaleStudents();

            universityManager.SortStudentsByAge();

            universityManager.AllStudentsFromBeijingTech();

            // get student with id
            Console.Write("Id of the student you want to get: ");
            string idString  = Console.ReadLine();
            bool res = int.TryParse(idString, out int id);
            if (res)
            {
                universityManager.StudentWithId(id);
            } else
            {
                Console.WriteLine("Please enter the valid id when running the app next time.");
            }

            Console.Read();
        }
    }
}
