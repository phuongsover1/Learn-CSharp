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

namespace _13_learn_wpf_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //StackPanel stackPanel = new StackPanel();
            //this.AddChild(stackPanel); 

            //TextBlock txt = new TextBlock();
            //txt.Text = "Hello World!";
            //txt.HorizontalAlignment = HorizontalAlignment.Center;

            //txt.Margin = new Thickness(30);
            //txt.Background = Brushes.AliceBlue;

            //stackPanel.Children.Add(txt);

            //ListBox list = new ListBox();
            //list.Height = 100;
            //list.Width = 100;


            //for(int i = 0; i < 3; i++)
            //{
            //    ListBoxItem listItem = new ListBoxItem();
            //    listItem.Content = $"Item {i + 1}";
            //    list.Items.Add(listItem);
            //}

            //stackPanel.Children.Add(list);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me!");
        }
    }
}
