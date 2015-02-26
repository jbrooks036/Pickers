using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pickers;
//using Pickers.Model;

namespace Pickers.Repository
{
    public class TuneRepository : ITuneRepository
    {
        private TuneContext _dbContext;

        public TuneRepository()
        {
            _dbContext = new TuneContext();
            _dbContext.Tunes.Load();

            // see the database
            _dbContext.Tunes.Add(new Model.Tune("Little Maggie"));
            _dbContext.Tunes.Add(new Model.Tune("Foggy Mountain Breakdown"));
            _dbContext.SaveChanges();
        }

        public TuneContext Context()
        {
            return _dbContext;
        }

        public DbSet<Model.Tune> GetDbSet()
        {
            return _dbContext.Tunes;
        }

        public int GetCount()
        {
            return _dbContext.Tunes.Count<Model.Tune>();
        }

        public void Add(Model.Tune T)
        {
            // TBD: error checking for adding duplicate tune, or migration on table
            _dbContext.Tunes.Add(T);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Tune T)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Tunes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Model.Tune> All()
        {
            var qu = from Tune in _dbContext.Tunes select Tune;
            return qu.ToList<Model.Tune>();
        }

        public Model.Tune GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Tune> SearchFor(System.Linq.Expressions.Expression<Func<Model.Tune, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
