using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorUtil
{
    public class StringCalculator
    {
        public int Add(string inputString)
        {
            List<string> delimeters = new List<string> { ",", "\n" };

            if (inputString.StartsWith("//"))
            {
                var newDelimeter = inputString.ToCharArray()[2];
                delimeters.Add(newDelimeter.ToString());
                inputString = inputString.Substring(3);
            }

            return Add(inputString, delimeters);
        }

        private static int Add(string inputString, List<string> delimeters)
        {
            string[] numbers = inputString.Split(delimeters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            foreach (var num in numbers)
            {
                int intNum;
                if (!IsValidNumber(num, out intNum))
                    throw new NotSupportedException("Only string numbers are supported");            

                if (intNum < 1000)
                {
                    result += intNum;
                }               
            }

            return result;
        }

        private static bool IsValidNumber(string number, out int num)
        {            
            if (!Int32.TryParse(number, out num))
                return false;

            if (num < 0)
                return false;

            return true;
        }
    }

    //

    // Requirement 1: The method can take 0, 1 or 2 numbers separated by comma (,).

    //Requirement 2: For an empty string the method will return 0

    // Requirement 3: Method will return their sum of numbers for two numbers

    //Requirement 4: Allow the Add method to handle an unknown amount of numbers

    //Requirement 5: Allow the Add method to handle new lines between numbers (instead of commas).
    // Requirement 6 : for any non number throw exception
    //Requirement 7: Support different delimiters

    //To change a delimiter, the beginning of the string will contain a 
    //separate line that looks like this: “//[delimiter]\n[numbers…]” for 
    //example “//;\n1;2” should take 1 and 2 as parameters and return 3 where the default delimiter is ‘;’ 
    
  

    //Requirement 8: Negative numbers will throw an exception

    //Requirement 9: Numbers bigger than 1000 should be ignored
}
