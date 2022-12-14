using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class PabCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PabCurrency()
        {
            Info = Currency.From(("B/.", CurrencyCodes.PAB, "590", "Panamanian Balboa", "centÚsimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
