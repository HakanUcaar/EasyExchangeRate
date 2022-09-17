using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class Currency : EasyValueOf<(string symbol, CurrencyCodes isoCode, string numericCode, string name, string subUnit), Currency>
    {
        public string Symbol => Value.symbol;
        public CurrencyCodes IsoCode => Value.isoCode;
        public string NumericCode => Value.numericCode;
        public string Name => Value.name;
        public string SubUnit => Value.subUnit;

        public override string ToString()
        {
            return Value.name;
        }
    }
}
