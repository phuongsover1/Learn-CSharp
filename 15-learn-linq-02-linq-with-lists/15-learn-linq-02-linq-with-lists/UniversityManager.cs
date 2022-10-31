using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_learn_linq_02_linq_with_lists
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University() { Id = 1, Name = "Yale" });
            universities.Add(new University() { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student() { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student() { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student() { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student() { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student() { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                               where student.Gender.Equals("male")
                                               select student;

            Console.WriteLine("Male student:");
            foreach(Student student in maleStudents)
            {
                Console.WriteLine(student);
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students
                                                  where student.Gender.Equals("female")
                                                  select student;

            Console.WriteLine("Female student:");
            foreach(Student student in femaleStudents)
            {
                Console.WriteLine(student);
            }
        }

        public void SortStudentsByAge()
        {
            IEnumerable<Student> sortedStudents = from student in students
                                                  orderby student.Age
                                                  select student;

            Console.WriteLine("Students sorted by Age:");
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> beijingTechStudents = from student in students
                                                       join university in universities
                                                       on student.UniversityId equals university.Id
                                                       where university.Name.Equals("Beijing Tech")
                                                       select student;

            Console.WriteLine("=== All Students From Beijing Tech ====");
            foreach(Student student in beijingTechStudents)
            {
                Console.WriteLine(student);
            }
        }



    }

}
