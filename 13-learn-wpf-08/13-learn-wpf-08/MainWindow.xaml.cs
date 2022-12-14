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

namespace _13_learn_wpf_08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Barca", Score1 = 3, Score2 = 6, Completion = 40 });
            matches.Add(new Match() { Team1 = "BVB Dotmund", Team2 = "PSG", Score1 = 2, Score2 = 1, Completion = 35 });
            matches.Add(new Match() { Team1 = "Machester United", Team2 = "Manchester City", Score1 = 3, Score2 = 6, Completion = 90 });
                
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Match match = lbMatches.SelectedItem as Match;
            if (match != null)
            {
                MessageBox.Show($"Selected Match: {match.Team1} {match.Score1}:{match.Score2} {match.Team2}");
            }
        }
    }
}
