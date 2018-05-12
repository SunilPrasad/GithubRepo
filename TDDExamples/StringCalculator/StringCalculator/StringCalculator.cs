using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        private IStringParser _parser;
        private IStringValidator _validator;

        public StringCalculator(IStringParser parser,IStringValidator validtor)
        {
            _parser = parser;
            _validator = validtor;
        }
        public int Add(string strNumbers)
        {
            string[] numberArray = _parser.Parse(strNumbers);

            int total = 0;

            foreach (var num in numberArray)
            {
                if (!_validator.Validate(num, out int intNum))
                    throw new NotSupportedException("There are some invlid numbers");

                total += intNum;
            }

            return total;


        }
    }
}
