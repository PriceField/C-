using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void MyTestTest()
        {
            int mock = 6;
            Test test = new Test();
            int result = test.MyTest(6);
            Assert.AreEqual(6 + 5, result);
        }
    }
}