using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Kgs Currency
    /// </summary>
    public class KgsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static KgsCurrency()
        {
            Info = Currency.From(("сом", CurrencyCodes.KGS, "417", "Kyrgystani Som", "tyiyn"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
