using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class TestCase2
    {
        public static int MaximumIntergerNumber(int firstvalue, int secondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }

    }
}
