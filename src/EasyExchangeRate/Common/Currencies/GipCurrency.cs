namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gip Currency
    /// </summary>
    public class GipCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GipCurrency()
        {
            Info = EasyCurrency.From(("£", CurrencyCodes.GIP, "292", "Gibraltar pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
