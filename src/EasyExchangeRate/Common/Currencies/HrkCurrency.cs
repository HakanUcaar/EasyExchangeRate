namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Hrk Currency
    /// </summary>
    public class HrkCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static HrkCurrency()
        {
            Info = EasyCurrency.From(("kn", CurrencyCodes.HRK, "191", "Croatian Kuna"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
