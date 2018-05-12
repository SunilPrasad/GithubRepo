using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator
{
    [TestClass]
    public class StringCalculatorTests
    {
        private IStringParser _parse;
        private StringCalculator stringCalculator;

        [TestInitialize]
        public void Init()
        {
            stringCalculator = new StringCalculator(new StringParser(),new StringValidator());
        }


        [Ignore]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenMoreThan2NumbersAreUsedThenExceptionIsThrown()
        {           

            stringCalculator.Add("1,2,3");
        }

        [TestMethod]
        public void when2NumbersAreUsedThenNoExceptionIsThrown()
        {
            stringCalculator.Add("1,2");
        }

        [TestMethod]
        public void whenEmptyStringIsUsedThenReturnValueIs0()
        {
            int res = stringCalculator.Add("");

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void WhenOnlyOneNumberIsUsedThenNoExceptionIsThrown()
        {           

            stringCalculator.Add("1");
        }

        [TestMethod]
        public void whenOneNumberIsUsedThenReturnValueIsThatSameNumber()
        {            
            int res = stringCalculator.Add("15");
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void whenTwoNumbersAreUsedThenReturnValueIsTheirSum()
        {            
            int res = stringCalculator.Add("15,12");
            Assert.AreEqual(27, res);
        }


        [TestMethod]
        public void whenAnyNumberOfNumbersIsUsedThenReturnValuesAreTheirSums()
        {            
            int res = stringCalculator.Add("3,6,15,18,46,33");
            Assert.AreEqual(3 + 6 + 15 + 18 + 46 + 33, res);
        }

        [TestMethod]
        public void whenNewLineIsUsedBetweenNumbersThenReturnValuesAreTheirSums()
        {            
            int res = stringCalculator.Add("6\n15");
            Assert.AreEqual(3 + 6 + 15, 3, res);
        }

        [TestMethod]
        public void whenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
        {            
            int res = stringCalculator.Add("//;\n3;6;15");
            Assert.AreEqual(3 + 6 + 15, res);

        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenNegativeNumbersAreUsedThenRuntimeExceptionIsThrown()
        {            
            int res = stringCalculator.Add("2,3,-9,2,4,5");
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenNonNumberIsUsedThenExceptionIsThrown()
        {            
            stringCalculator.Add("1,X");
        }
    }
}
