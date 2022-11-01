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

            DeleteAllUniversities();
        }

        private void InsertUniversities(string name)
        {
            University uni = new University() { Name = name};
            

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

             
        }
    }
}
