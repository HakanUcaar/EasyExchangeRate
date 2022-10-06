using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Bam Currency
    /// </summary>
    public class BamCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BamCurrency()
        {
            Info= Currency.From(("КМ", CurrencyCodes.BAM, "977", "Bosnia and Herzegovina convertible mark", "fening"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
