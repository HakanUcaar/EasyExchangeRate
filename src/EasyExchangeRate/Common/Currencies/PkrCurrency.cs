using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class PkrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PkrCurrency()
        {
            Info = Currency.From(("Rs", CurrencyCodes.PKR, "586", "Pakistani Rupee", "paisa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
