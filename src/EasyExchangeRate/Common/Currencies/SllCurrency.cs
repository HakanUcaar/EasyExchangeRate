using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class SllCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static SllCurrency()
        {
            Info = Currency.From(("Le", CurrencyCodes.SLL, "694", "Sierra Leonean leone", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
