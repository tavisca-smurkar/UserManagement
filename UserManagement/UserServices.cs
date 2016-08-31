using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace UserManagement
{
    public class UserServices: IUserServices
    {
        public void delete_user(long id)
        {
            DataClasses1DataContext datacontext = new DataClasses1DataContext();
            int rows_deleted = datacontext.spDeleteUser(id).SingleOrDefault().Column1;
            
        }

        public Int64 CreateUser(User user)
        {
            DataClasses1DataContext datacontext = new DataClasses1DataContext();

            Int64 ID = (Int64)datacontext.spCreateUser(user.FirstName, user.LastName).FirstOrDefault().Column1.Value;

            return ID;
        }

        public Int64 update_user_firstName(long id, string firstName)
        {
            DataClasses1DataContext datacontext = new DataClasses1DataContext();
          
            datacontext.spUpdateUser(id, firstName);

            return id;





        }
    }
}
