using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
        public class MaximumNumberCheck<T> where T : IComparable
        {
            public T firstvalue, secondvalue, thirdvalue;
            public MaximumNumberCheck(T firstvalue, T secondvalue, T thirdvalue)
            {
                this.firstvalue = firstvalue;
                this.secondvalue = secondvalue;
                this.thirdvalue = thirdvalue;
            }
            public static T Maximum(T firstvalue, T secondvalue, T thirdvalue)
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
