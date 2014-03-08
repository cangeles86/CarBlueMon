using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SanPablo.CarBluMon.Test.Data
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int index = 1;
            index += 1;
            Assert.AreEqual(2, index);
        }
    }
}
