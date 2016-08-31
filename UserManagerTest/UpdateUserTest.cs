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
            user.Id = 10005;
            UserServices service = ServiceFactory.getService();
            var result = service.update_user_firstName(user.Id,user.FirstName);
            Assert.IsTrue(result != 0);
        }
    }
}
