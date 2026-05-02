using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Utils
{
    public static class DigitStandarizer
    {
        public static decimal ValidarDecimalPos(decimal num)
        {
            if (decimal.IsNegative(num)) return 0;
            return num;

        }
    }
}
