using EasyExchangeRate;
using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Idr Currency
    /// </summary>
    public class IdrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static IdrCurrency()
        {
            Info= Currency.From(("Rp", CurrencyCodes.IDR, "360", "Indonesian Rupiah", "sen"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
