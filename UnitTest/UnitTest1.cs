using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaPlanerServer.Objects;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = new User("Richard", "Test");
            

            byte[] test = user.Serialize();


            User obj = User.Deserialize(test);
            Assert.AreEqual(obj, user);
        }
    }
}
