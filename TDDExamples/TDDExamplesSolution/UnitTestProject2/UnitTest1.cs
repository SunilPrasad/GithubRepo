using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("12,3");
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void TestMethod12()
        {
            StringCalculator stringCalculator = new StringCalculator();
            var res = stringCalculator.Add("10,3");
            Assert.AreEqual(13, res);
        }

        // string calculator
        // 1,2,3 = 6
    }
}
