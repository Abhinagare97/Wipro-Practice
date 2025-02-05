using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestings
{
    [TestClass]
    public class UnitTest1
    {
        BasicMathOperations bm = new BasicMathOperations();

        [TestMethod]
        public void TestMethod1()
        {
            public void test_add()
        {
            int result = bm.Add(4,4);
            Assert.AreEqual(8, result);
        }
        }
    }
}
