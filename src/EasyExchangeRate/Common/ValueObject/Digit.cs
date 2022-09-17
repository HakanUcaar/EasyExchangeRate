using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class Digit : EasyValueOf<(string singular,string plural, long number), Digit>
    {
        public string Singular => Value.singular;
        public string Plural => Value.plural;
        public long Number => Value.number;

        public override string ToString()
        {
            return $"{Value.singular}";
        }
        public string ToSingular()
        {
            return $"{Value.singular}";
        }

        public string ToPlural()
        {
            return $"{Value.plural}";
        }
    }
}
