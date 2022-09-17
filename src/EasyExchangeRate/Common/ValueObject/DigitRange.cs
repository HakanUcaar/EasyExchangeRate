using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class DigitRange : EasyValueOf<(int min, int max), DigitRange>
    {
        public int Min => Value.min;
        public int Max => Value.max;
    }
}
