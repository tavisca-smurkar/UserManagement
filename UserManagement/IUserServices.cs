using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace UserManagement
{
   public interface IUserServices
    {
        void delete_user(long id);
        Int64 CreateUser(User user);
        Int64 update_user_firstName(long id, string firstName);
    }
}
