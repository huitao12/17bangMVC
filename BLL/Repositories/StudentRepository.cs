using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class StudentRepository
    {
        public Student Find(int id)
        {
            throw new NotFiniteNumberException();
        }
        public Student GetByName(string name)
        {
            SqlDbContext context = new SqlDbContext();
            return context.Students.Where(r => r.Name == name).SingleOrDefault();
        }

        public int Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
