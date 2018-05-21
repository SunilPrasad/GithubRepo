using System;
using System.Collections.Generic;
using System.Linq;
namespace StringCalculator
{
    public class StringParser : IStringParser
    {
        public IEnumerable<int> Parse(string strNumbers)
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
            return numberArray.ToList().Select(x => Convert.ToInt32(x));
        }
    }
}