using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorUtil;

namespace StringCalculatorUnitTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [Ignore]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenMoreThan2NumbersAreUsedThenExceptionIsThrown()
        {
            StringCalculator stringCalculator = new StringCalculator();

            stringCalculator.Add("1,2,3");
        }

        [TestMethod]
        public void when2NumbersAreUsedThenNoExceptionIsThrown()
        {
            StringCalculator stringCalculator = new StringCalculator();

            stringCalculator.Add("1,2");
        }

        [TestMethod]
        public void whenEmptyStringIsUsedThenReturnValueIs0()
        {
            StringCalculator stringCalculator = new StringCalculator();

            int res = stringCalculator.Add("");

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void WhenOnlyOneNumberIsUsedThenNoExceptionIsThrown()
        {
            StringCalculator stringCalculator = new StringCalculator();

            stringCalculator.Add("1");
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenNonNumberIsUsedThenExceptionIsThrown()
        {
            StringCalculator stringCalculator = new StringCalculator();
            stringCalculator.Add("1,X");
        }

        [TestMethod]
        public void whenOneNumberIsUsedThenReturnValueIsThatSameNumber()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("15");
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void whenTwoNumbersAreUsedThenReturnValueIsTheirSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("15,12");
            Assert.AreEqual(27, res);
        }


        [TestMethod]
        public void whenAnyNumberOfNumbersIsUsedThenReturnValuesAreTheirSums()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("3,6,15,18,46,33");
            Assert.AreEqual(3 + 6 + 15 + 18 + 46 + 33, res);            
        }

        [TestMethod]
        public void whenNewLineIsUsedBetweenNumbersThenReturnValuesAreTheirSums()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("6\n15");
            Assert.AreEqual(3 + 6 + 15, 3, res);            
        }

        [TestMethod]
        public void whenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("//;\n3;6;15");
            Assert.AreEqual(3 + 6 + 15,  res);
            
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void whenNegativeNumbersAreUsedThenRuntimeExceptionIsThrown()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("2,3,-9,2,4,5");            
        }

        [TestMethod]
        public void whenOneOrMoreNumbersAreGreaterThan1000IsUsedThenItIsNotIncludedInSum()
        {
            StringCalculator stringCalculator = new StringCalculator();
            int res = stringCalculator.Add("3,1000,1001,6,1234");
            Assert.AreEqual(3 + 6 , res);          
        }
    }
}

