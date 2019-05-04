using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.EF.Repository
{
  public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetByID(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);

    }
}
