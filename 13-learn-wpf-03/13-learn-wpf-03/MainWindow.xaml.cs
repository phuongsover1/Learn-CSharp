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

namespace _13_learn_wpf_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // the event of the button is directly called by the click property
            MessageBox.Show("Buton was clicked - Direct event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was released");
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MouseUp event on grid");
        }

        private void Button_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void Grid_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PreviewMouseUp on grid - Tunneling");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PreviewMouseUp on button - Tunneling");
        }
    }
}
