using System;

namespace StringCalculator
{
    public class StringParser : IStringParser
    {
        public string[] Parse(string strNumbers)
        {
            char[] delemiters = new char[] { ',', '\n' };

            var isDelimeterExist = strNumbers.StartsWith("//");

            if (isDelimeterExist)
            {
                var newDelimeter = strNumbers[2];
                delemiters[0] = newDelimeter;
                strNumbers = strNumbers.Substring(3, strNumbers.Length - 3);
            }

            var numberArray = strNumbers.Split(delemiters, StringSplitOptions.RemoveEmptyEntries);
            return numberArray;
        }
    }
}