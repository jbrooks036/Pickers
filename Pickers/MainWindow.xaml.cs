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

namespace Pickers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Boolean SearchEnabled;

        public MainWindow()
        {
            InitializeComponent();
            SearchEnabled = false;
        }

        private void SearchArtistTextBox_Click(object sender, RoutedEventArgs e)
        {
            SearchArtistTextBox.IsEnabled = true;
            SearchTuneTextBox.IsEnabled = false;
            SearchTuneTextBox.Text = "";
            SearchButton.IsEnabled = true;
        }

        private void SearchTuneTextBox_Click(object sender, RoutedEventArgs e)
        {
            SearchTuneTextBox.IsEnabled = true;
            SearchArtistTextBox.IsEnabled = false;
            SearchArtistTextBox.Text = "";
            SearchButton.IsEnabled = true;
        }

        private void SearchTuneTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
