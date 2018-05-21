using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringValidator : IStringValidator
    {
        public void Validate(int []numbers)
        {
            foreach (var num in numbers)
            {
                if (num < 0)
                    throw new NotSupportedException();
            }
        }

    }
}
