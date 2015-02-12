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
        public string Name { get; set; }

        public Tune()
        {
            // placeholder
        }

        public Tune(string TuneName)
        {
            this.Name = TuneName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
