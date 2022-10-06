using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ves Currency
    /// </summary>
    public class VesCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static VesCurrency()
        {
            Info = Currency.From(("Bs.S", CurrencyCodes.VES, "928", "Venezuelan Bolívar",""));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
