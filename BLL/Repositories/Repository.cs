using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class Repository<T>  where T : BaseEntity
    {
        protected SqlDbContext<T> context;
        public Repository()
        {
            //context = new SqlDbContext<T>();
        }
        public int Save(T entity)
        {
            context.Entities.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
        public void Remove(T entiry)
        {


        }
    }
}
