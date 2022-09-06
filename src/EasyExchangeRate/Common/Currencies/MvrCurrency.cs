namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mvr Currency
    /// </summary>
    public class MvrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MvrCurrency()
        {
            Info = EasyCurrency.From(("ރ.", CurrencyCodes.MVR, "462", "Maldivian Rufiyaa"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
