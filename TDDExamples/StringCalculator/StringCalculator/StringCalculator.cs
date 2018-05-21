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
            var numberArray = _parser.Parse(strNumbers).ToArray();

            _validator.Validate(numberArray);

           return numberArray.Aggregate(0, (total, x) => total + x);

        }
    }
}
