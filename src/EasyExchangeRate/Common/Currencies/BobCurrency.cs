using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bob Currency
    /// </summary>
    public class BobCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BobCurrency()
        {
            Info = Currency.From(("Bs", CurrencyCodes.BOB, "068", "Bolivian boliviano", "centavo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
