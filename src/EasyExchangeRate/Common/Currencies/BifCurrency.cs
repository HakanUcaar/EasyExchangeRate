namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bif Currency
    /// </summary>
    public class BifCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BifCurrency()
        {
            Info = EasyCurrency.From(("FBu", CurrencyCodes.BIF, "108", "Burundian franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
