using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pickers;

namespace Pickers.Repository
{
    public class TuneRepository : ITuneRepository
    {
        private TuneContext _dbContext;

        public TuneRepository()
        {
            _dbContext = new TuneContext();
            _dbContext.Tunes.Load();
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
            throw new NotImplementedException();
        }

        public void Add(Model.Tune T)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model.Tune T)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Tune> All()
        {
            throw new NotImplementedException();
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
