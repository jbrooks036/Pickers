using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using Pickers;
using Pickers.Model;
using Pickers.Repository;

namespace Pickers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Boolean SearchEnabled;

        //public ObservableCollection<Tune> Tunes;
        //public static TuneContext _dbContext;
        public static TuneRepository repo = new TuneRepository();
        public MainWindow()
        {
            InitializeComponent();
            TunesGrid.DataContext = repo.Context().Tunes.Local;
            SearchEnabled = false;
        }

        private void SearchArtistTextBox_Click(object sender, RoutedEventArgs e)
        {
            SearchArtistBox.IsEnabled = true;
            SearchTuneBox.IsEnabled = false;
            SearchTuneBox.Text = "";
            SearchButton.IsEnabled = true;
        }

        private void SearchTuneTextBox_Click(object sender, RoutedEventArgs e)
        {
            SearchTuneBox.IsEnabled = true;
            SearchArtistBox.IsEnabled = false;
            SearchArtistBox.Text = "";
            SearchButton.IsEnabled = true;
        }

        private void SearchTuneTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            repo.Add(new Tune(ArtistNameInputBox.Text, 
                              TuneNameInputBox.Text, 
                              AlbumTitleInputBox.Text)); 
        }

    }
}
