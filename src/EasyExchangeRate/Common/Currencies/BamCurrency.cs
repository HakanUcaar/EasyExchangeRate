namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bam Currency
    /// </summary>
    public class BamCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BamCurrency()
        {
            Info= EasyCurrency.From(("КМ", CurrencyCodes.BAM, "977", "Bosnia and Herzegovina convertible mark"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
