using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;
using UserManagement;

namespace UserManagerTest
{
    [TestClass]
    public class DeleteUser
    {
        [TestMethod]
        public void TestDeleteUser()
        {
            User user = new User();
            user.Id = 1;
            UserServices service = new UserServices();
            service.delete_user(user.Id);
            
        }
    }
}
