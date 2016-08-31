using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;
using UserManagement;

namespace UserManagerTest
{
    [TestClass]
    public class CreateUserTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception)]
        public void TestCreateUser()
        {
            User user = new User();
            
            user.FirstName = "John";
            user.LastName = "Doe";
            UserServices service = new UserServices();
            Int64 result = service.CreateUser(user);
            user.Id = result;
            Assert.IsTrue(result>0);
            
        }
    }
}
