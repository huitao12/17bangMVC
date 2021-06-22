using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class Repository<T>  where T : BaseEntity
    {
        protected SqlDbContext context;
        protected DbSet<T> dbSet;
        public Repository(SqlDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        
        public int Save(T entity)
        {
            //context.Set<T>().Add(entity);
            //context.Entities.Add(entity);
            dbSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }
    }
}
