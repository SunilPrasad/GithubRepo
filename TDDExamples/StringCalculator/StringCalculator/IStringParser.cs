using System.Collections.Generic;

namespace StringCalculator
{
    public interface IStringParser    {
        IEnumerable<int> Parse(string strNumbers);
    }
}