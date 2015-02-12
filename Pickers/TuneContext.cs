using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pickers.Model;

namespace Pickers
{
    public class TuneContext: DbContext
    {
        public DbSet<Tune> Tunes { get; set; }
    }
}
