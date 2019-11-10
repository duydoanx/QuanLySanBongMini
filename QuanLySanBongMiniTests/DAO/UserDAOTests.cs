using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO.Tests
{
    [TestClass()]
    public class UserDAOTests
    {
        [TestMethod()]
        public void getUserTest()
        {
            User user = UserDAO.getUser("duydoan", "1230456");
            User user1 = new User("duydoan", "1230456", true);
            Assert.AreEqual(user1.toString(), user.toString());


        }
    }
}