namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bmd Currency
    /// </summary>
    public class BmdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BmdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.BMD, "060", "Bermudian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
