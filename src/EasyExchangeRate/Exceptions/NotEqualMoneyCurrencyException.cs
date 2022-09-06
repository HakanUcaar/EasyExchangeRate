using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate
{
    internal class NotEqualMoneyCurrencyException : Exception
    {
        public NotEqualMoneyCurrencyException() : base($"Two money currency not equal")
        {
        }
    }
}
