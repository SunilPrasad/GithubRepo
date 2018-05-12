using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringParserTests
    {
        [TestMethod]
        public void ShouldReturnNumberArrayPassedWithDelimeter()
        {
            var stringParser = new StringParser();
            Assert.AreEqual("1", stringParser.Parse("1")[0]);
        }

    }
}
