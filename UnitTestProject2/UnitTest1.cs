using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c1 = new Class1();

            var result = c1.UselessMethod(5);

            Assert.AreEqual(25, result);
        }
    }
}
