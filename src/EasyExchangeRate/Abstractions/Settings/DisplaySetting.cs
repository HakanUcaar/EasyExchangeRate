using Optionable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate
{
    public enum NotationType
    {
        //1234.56 -> 1,234.56
        Standard = 0,
        //1234.56 -> 1.2K
        Compact = 1,
    }

    public enum RotationType
    {
        //1234 -> $ 1234
        Prefix = 0,
        //1234 -> 1234 $
        Suffix = 1,
    }

    public enum DisplayType
    {
        Symbol = 0,
        Name = 1,
    }

    public class DisplaySetting : IOption
    {
        public bool CurrencyDisplay { get; set; } = true;
        public NotationType Notation { get; set; } = NotationType.Standard;
        public RotationType SymbolRotation { get; set; } = RotationType.Prefix;
        public DisplayType Display{ get; set; } = DisplayType.Symbol;
    }
}
