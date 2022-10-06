using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bnd Currency
    /// </summary>
    public class BndCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BndCurrency()
        {
            Info = Currency.From(("$", CurrencyCodes.BND, "096", "Brunei dollar", "sen"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
