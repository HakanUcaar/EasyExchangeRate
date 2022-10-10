using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate
{
    public class CurrencyNotFoundException : Exception
    {
        public CurrencyNotFoundException() : base($"Currency not found")
        {

        }
    }
}
