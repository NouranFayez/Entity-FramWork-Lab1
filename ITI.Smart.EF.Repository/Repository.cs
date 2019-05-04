using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.EF.Repository
{
    public class Repository<TEnitity, TContext> : IRepository<TEnitity>
        where TEnitity:class
        where TContext : DbContext , new()
    {
        TContext context;
        DbSet<TEnitity> set;
        public Repository(TContext context)
        {
            this.context = context;
            set = context.Set<TEnitity>();

        }
        public TEnitity Add(TEnitity entity)
        {
             set.Add(entity);
            return context.SaveChanges() > 0 ? entity :null;
        }

        public IQueryable<TEnitity> GetAll()
        {
            return set;
        }

        public TEnitity GetByID(params object[] id)
        {
            return set.Find(id);
        }

        public bool Remove(TEnitity entity)
        {
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEnitity entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}
