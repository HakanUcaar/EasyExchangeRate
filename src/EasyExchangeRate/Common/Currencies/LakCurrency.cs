namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lak Currency
    /// </summary>
    public class LakCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LakCurrency()
        {
            Info = EasyCurrency.From(("₭", CurrencyCodes.LAK, "418", "Laotian Kip"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
