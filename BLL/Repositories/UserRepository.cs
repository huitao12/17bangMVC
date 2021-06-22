using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SqlDbContext context) : base(context)
        {
        }

        public User Find(int id)
        {
            return dbSet.Find(id);
            //throw new NotFiniteNumberException();
        }
        public User GetByName(string name)
        {
            return dbSet
                .Where(s => s.Name == name)
                .SingleOrDefault();
        }
    }
}
