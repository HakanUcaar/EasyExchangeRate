using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ern Currency
    /// </summary>
    public class ErnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ErnCurrency()
        {
            Info = Currency.From(("Nfk", CurrencyCodes.ERN, "232", "Eritrean nakfa", "cent"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
