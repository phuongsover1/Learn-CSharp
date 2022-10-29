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

namespace _13_learn_wpf_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            
            Button btn = new Button();
            btn.Content = "Click me!!!";
            btn.FontSize = 26;
            btn.Height = 50;
            btn.Width = 300;

            WrapPanel wrapPanel = new WrapPanel();

            TextBlock text1 = new TextBlock();
            text1.Text = "Text 1";
            text1.Foreground = Brushes.Red;
            wrapPanel.Children.Add(text1);

            text1 = new TextBlock();
            text1.Text = "Text 2";
            text1.Foreground = Brushes.Green;
            wrapPanel.Children.Add(text1);


            text1 = new TextBlock();
            text1.Text = "Text 3";
            text1.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(text1);


            btn.Content = wrapPanel;
 
            grid.Children.Add(btn);


            this.Content = grid;
        }
    }
}
