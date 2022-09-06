namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Myr Currency
    /// </summary>
    public class MyrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MyrCurrency()
        {
            Info = EasyCurrency.From(("RM", CurrencyCodes.MYR, "458", "Malaysian Ringgit"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
