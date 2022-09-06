using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class EasyCurrency : EasyValueOf<(string Symbol, CurrencyCodes IsoCode, string NumericCode, string Name), EasyCurrency>
    {
        public string Symbol => Value.Symbol;
        public CurrencyCodes IsoCode => Value.IsoCode;
        public string NumericCode => Value.NumericCode;
        public string Name => Value.Name;

        public override string ToString()
        {
            return Value.Name;
        }
    }
}
