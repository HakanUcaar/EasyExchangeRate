namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kzt Currency
    /// </summary>
    public class KztCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KztCurrency()
        {
            Info = EasyCurrency.From(("₸", CurrencyCodes.KZT, "398", "Kazakhstani Tenge"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
