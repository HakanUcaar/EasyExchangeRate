namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bzd Currency
    /// </summary>
    public class BzdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BzdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.BZD, "084", "Belize dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
