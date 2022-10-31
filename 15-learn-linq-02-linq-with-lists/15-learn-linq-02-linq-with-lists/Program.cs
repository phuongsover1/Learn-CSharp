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

            Console.Read();
        }
    }
}
