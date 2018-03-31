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
            int result = 0;
            string []numbers = inputString.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
            
           foreach(var num in numbers)
            {
                int intNum;
                if (!Int32.TryParse(num, out intNum))
                    throw new NotSupportedException("Only string numbers are supported");

                result += intNum;
            }

            return result;
        }
    }

    //

    // Requirement 1: The method can take 0, 1 or 2 numbers separated by comma (,).

    //Requirement 2: For an empty string the method will return 0

    // Requirement 3: Method will return their sum of numbers

    //Requirement 4: Allow the Add method to handle an unknown amount of numbers

    //Requirement 5: Allow the Add method to handle new lines between numbers (instead of commas).

    //Requirement 6: Support different delimiters

    //To change a delimiter, the beginning of the string will contain a 
    //separate line that looks like this: “//[delimiter]\n[numbers…]” for 
    //example “//;\n1;2” should take 1 and 2 as parameters and return 3 where the default delimiter is ‘;’ 

    //Requirement 7: Negative numbers will throw an exception

    //Requirement 8: Numbers bigger than 1000 should be ignored
}
