using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringValidator : IStringValidator
    {
        public bool Validate(string number,out int numInt)
        {          
            if (!Int32.TryParse(number, out numInt))
                return false;

            if (numInt < 0)
                return false;

            return true; ;
        }

    }
}
