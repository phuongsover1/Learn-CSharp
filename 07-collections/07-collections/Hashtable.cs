using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_collections
{
    internal class _Hashtable
    {
        public static void Run()
        {
            Hashtable hashtable = new Hashtable();

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 76);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 55);

            hashtable.Add(student1.Id, student1);
            hashtable.Add(student2.Id, student2);
            hashtable.Add(student3.Id, student3);
            hashtable.Add(student4.Id, student4);

            // retriving data from hashtable
            Student storedStudent1 = (Student)hashtable[student1.Id];

            // loop through hashtable
            foreach(DictionaryEntry entry in hashtable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student's id :{0}", temp.Id);
                Console.WriteLine("Student's name :{0}", temp.Name);
                Console.WriteLine("Student's GPA :{0}", temp.GPA);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
