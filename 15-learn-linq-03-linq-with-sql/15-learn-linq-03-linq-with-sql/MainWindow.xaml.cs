using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace _15_learn_linq_03_linq_with_sql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["_15_learn_linq_03_linq_with_sql.Properties.Settings.wpf_zooConnectionString"].ConnectionString;

            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities("Beijing Tech");
            //InsertUniversities("Yale");

            //DeleteAllUniversities();

            //InsertStudent();

            //InsertLecture("Math");
            //InsertLecture("History");

            //InsertStudentLectureAssociations();
            //GetUniversityOfToni();

            //GetLecturesFromToni();

            //GetAllStudentsFromYale();
            //GetAllUniversityWithFemale();
            GetLecturesFromUni("Beijing Tech");
        }

        private void InsertUniversities(string name)
        {
            University uni = new University() { Name = name };


            dataContext.Universities.InsertOnSubmit(uni);
            dataContext.SubmitChanges();

            DataGrid.ItemsSource = dataContext.Universities;
        }

        private void DeleteAllUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            dataContext.SubmitChanges();

            DataGrid.ItemsSource = dataContext.Universities;
        }

        private void InsertStudent()
        {
            University yale = dataContext.Universities.First(uni => uni.Name.Equals("Yale"));
            University beijingTech = dataContext.Universities.First(uni => uni.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student() { Name = "Carla", Age = 19, Gender = "female", UniversityId = yale.Id });
            students.Add(new Student() { Name = "Toni", Age = 21, Gender = "male", University = yale });
            students.Add(new Student() { Name = "Layle", Age = 20, Gender = "female", University = beijingTech });
            students.Add(new Student() { Name = "Jane", Age = 17, Gender = "female", University = yale });

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();

            DataGrid.ItemsSource = dataContext.Students;

        }

        private void InsertLecture(string name)
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = name });
            dataContext.SubmitChanges();
        }

        private void InsertStudentLectureAssociations()
        {
            Student carla = dataContext.Students.First(student => student.Name.Equals("Carla"));
            Student toni = dataContext.Students.First(student => student.Name.Equals("Toni"));

            // get lectures
            Lecture math = dataContext.Lectures.First(lecture => lecture.Name.Equals("Math"));
            Lecture history = dataContext.Lectures.First(lecture => lecture.Name.Equals("History"));

            // method 1
            Student_Lecture carlaLectures = new Student_Lecture() { StudentId = carla.Id, LectureId = math.Id };

            // method 2
            Student_Lecture toniLectures = new Student_Lecture() { Student = toni, Lecture = history };


            dataContext.Student_Lectures.InsertAllOnSubmit(new List<Student_Lecture>() { carlaLectures, toniLectures });

            dataContext.SubmitChanges();

            DataGrid.ItemsSource = dataContext.Student_Lectures;


        }

        private void GetUniversityOfToni()
        {
            try
            {
                Student toni = dataContext.Students.First(s => s.Name.Equals("Toni"));
                University uniOfToni = toni.University;

                DataGrid.ItemsSource = new List<University>() { uniOfToni };

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void GetLecturesFromToni()
        {
            try
            {
                Student toni = dataContext.Students.First(s => s.Name.Equals("Toni"));
                var toniLectures = from lectureId in toni.Student_Lectures
                                   select lectureId.Lecture;

                DataGrid.ItemsSource = toniLectures;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name.Equals("Yale")
                                   select student;

            DataGrid.ItemsSource = studentsFromYale;


        }

        private void GetAllUniversityWithFemale()
        {
            var universitiesWithFemale = (from student in dataContext.Students
                                          join university in dataContext.Universities on student.UniversityId equals university.Id
                                          where student.Gender.Equals("female")
                                          select university).Distinct();

            DataGrid.ItemsSource = universitiesWithFemale;
        }

        private void GetLecturesFromUni(string universityName)
        {
            var lecturesFromUni = (from sl in dataContext.Student_Lectures
                                  join student in dataContext.Students
                                  on sl.Student equals student
                                  where student.University.Name.Equals(universityName)
                                  select sl.Lecture).Distinct();

            DataGrid.ItemsSource = lecturesFromUni;
        }

    }
}
