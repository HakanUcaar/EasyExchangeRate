using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Ghs Currency
    /// </summary>
    public class GhsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static GhsCurrency()
        {
            Info = Currency.From(("GH₵", CurrencyCodes.GHS, "936", "Ghanaian cedi", "pesewa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
