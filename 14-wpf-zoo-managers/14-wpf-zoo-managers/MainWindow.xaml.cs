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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _14_wpf_zoo_managers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["_14_wpf_zoo_managers.Properties.Settings.wpf_zooConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // the SqlDAtaAdapter can be imageined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);


                    // Which Information of the Table in DataTable should be shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";
                    // Which Value should be delivered, when an Item from our ListBox is selected?
                    listZoos.SelectedValuePath = "Id";
                    // The Reference to the Data in the ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void lbAssociatedAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void showAssociatedAnimals()
        {

            // get the associated animals from zoo with idZoo
            string query = "select a.Id, a.Name from (select ZooId,AnimalId from Zoo_Animal) za, Animal a where za.ZooId = @ZooId and za.AnimalId = a.Id;";

            // if we declare a variable in query, we should use SqlCommand to set the value into that variable
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                using (sqlDataAdapter)
                {
                    DataTable associatedAnimalsTable = new DataTable();
                    sqlDataAdapter.Fill(associatedAnimalsTable);


                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = associatedAnimalsTable.DefaultView;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void showAvailableAnimalsToAddToTheZoo()
        {
            // get the available animal to add to the zoo
            string query = "select * from Animal a Where a.Id NOT IN (select AnimalId from Zoo_Animal where ZooId = @ZooId)";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                using (sqlDataAdapter)
                {
                    DataTable availableAnimalsTable = new DataTable();
                    sqlDataAdapter.Fill(availableAnimalsTable);

                    listAvailableAnimals.DisplayMemberPath = "Name";
                    listAvailableAnimals.SelectedValuePath = "Id";
                    listAvailableAnimals.ItemsSource = availableAnimalsTable.DefaultView;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            showAssociatedAnimals();
            showAvailableAnimalsToAddToTheZoo();
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            string query = "delete from Zoo where Zoo.Id = @ZooId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            string trimText = textBox.Text.Trim();
            if (trimText != "")
            {
                string query = "insert Zoo(Location) values(@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Location", trimText);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteScalar();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } finally
                {
                    sqlConnection.Close();
                    ShowZoos();
                }
            }
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            string trimText = textBox.Text.Trim();
            if (trimText != "")
            {
                string query = "update Zoo set location = @Location where Zoo.Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();

                }


            }
        }
    }
}
