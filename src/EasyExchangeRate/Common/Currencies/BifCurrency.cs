using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bif Currency
    /// </summary>
    public class BifCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BifCurrency()
        {
            Info = Currency.From(("FBu", CurrencyCodes.BIF, "108", "Burundian franc", "centime"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
