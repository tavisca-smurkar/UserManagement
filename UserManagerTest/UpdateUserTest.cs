using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;
using UserManagement;

namespace UserManagerTest
{
    
    [TestClass]
    public class UpdateUserTest
    {
        [TestMethod]
        public void TestUpdateUser()
        {
            User user = new User();
            user.FirstName = "Shreekesh";
            user.Id = 1;
            UserServices service = new UserServices();
            Int64 result = service.update_user_firstName(user.Id,user.FirstName);
            Assert.IsTrue(result != 0);
        }
    }
}
