using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _15_learn_linq_02_xml
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // We simply apply out Student Structure to XML
            string studentXML =
                @"<Students>
                    <Student>
                        <Name>Tonic</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                    </Student>
                    <Student>
                        <Name>Layla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                    </Student>
                </Students>";

            XDocument studentsXDoc = new XDocument();
            studentsXDoc = XDocument.Parse(studentXML);

            Print_AllStudents(studentsXDoc);

            Console.Read();
        }

        private static void Print_AllStudents(XDocument studentsXDoc)
        {
            var students = from student in studentsXDoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Age: {1}, University: {2}",student.Name, student.Age, student.University);
            }

        }
    }
}
