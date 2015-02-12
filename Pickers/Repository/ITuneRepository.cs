using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pickers.Model;

namespace Pickers.Repository
{
    public interface ITuneRepository
    {
        int GetCount();
        void Add(Tune T);
        void Delete(Tune T);
        void Clear();
        IEnumerable<Tune> All();
        Tune GetById(int id);
        IQueryable<Tune> SearchFor(Expression<Func<Tune, bool>> predicate);
    }
}
