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


        public void whenNewLineIsUsedBetweenNumbersThenReturnValuesAreTheirSums()
        {
            // Assert.assertEquals(3 + 6 + 15, StringCalculator.add("3,6n15"));
        }

        public void whenDelimiterIsSpecifiedThenItIsUsedToSeparateNumbers()
        {
            // Assert.assertEquals(3 + 6 + 15, StringCalculator.add("//;n3;6;15"));
        }

        public void whenOneOrMoreNumbersAreGreaterThan1000IsUsedThenItIsNotIncludedInSum()
        {
            // Assert.assertEquals(3 + 1000 + 6, StringCalculator8.add("3,1000,1001,6,1234"));
        }
    }
}

