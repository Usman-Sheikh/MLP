using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Data
{
    public interface IRepository<T>
                      where T : class
    {
        IEnumerable<T> SelectAll();
      //  IEnumerable<T> Select(Expression<Func<T, bool>> predicate);
        T SelectByID(object id);
        void Insert(T newEntity);
        void Update(T entity);
        void Delete(object id);
        void Save();
    }
}
