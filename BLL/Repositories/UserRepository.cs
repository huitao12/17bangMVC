using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : Repository<User>
    {
        public User Find(int id)
        {
            throw new NotFiniteNumberException();
        }
        public User GetByName(string name)
        {
            return context.Entities.Where(r => r.Name == name).SingleOrDefault();
        }
    }
}
