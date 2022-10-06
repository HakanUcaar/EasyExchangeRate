using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ngn Currency
    /// </summary>
    public class NgnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static NgnCurrency()
        {
            Info = Currency.From(("₦", CurrencyCodes.NGN, "566", "Nigerian Naira", "kobo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
