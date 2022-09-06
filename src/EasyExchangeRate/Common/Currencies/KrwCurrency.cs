namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Krw Currency
    /// </summary>
    public class KrwCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KrwCurrency()
        {
            Info = EasyCurrency.From(("₩", CurrencyCodes.KRW, "410", "South Korean Won"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
