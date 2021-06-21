using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository
    {
        public User Find(int id)
        {
            throw new NotFiniteNumberException();
        }
        public User GetByName(string name)
        {
            SqlDbContext context = new SqlDbContext();
            return context.Users.Where(r => r.Name == name).SingleOrDefault();
        }

        public int Save(User student)
        {
            throw new NotImplementedException();
        }
    }
}
