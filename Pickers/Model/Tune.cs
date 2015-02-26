using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickers.Model
{
    public class Tune : INotifyPropertyChanged
    {
        public int TuneId { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }

        public Tune()
        {
            // placeholder
        }

        public Tune(string TuneName)
        {
            this.Artist = "";
            this.Name = TuneName;
            this.Album = "";
        }

        public Tune(string ArtistName, string TuneName, string AlbumName)
        {
            this.Artist = ArtistName;
            this.Name = TuneName;
            this.Album = AlbumName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
