using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User : BaseEntity
    {
        public User InvitedBy { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public void Register()
        {

        }
    }
}
