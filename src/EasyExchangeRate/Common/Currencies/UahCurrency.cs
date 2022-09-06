namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Uah Currency
    /// </summary>
    public class UahCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static UahCurrency()
        {
            Info = EasyCurrency.From(("₴", CurrencyCodes.UAH, "980", "Ukrainian Hryvnia"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
