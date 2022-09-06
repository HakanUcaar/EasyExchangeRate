namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bdt Currency
    /// </summary>
    public class BdtCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BdtCurrency()
        {
            Info = EasyCurrency.From(("৳", CurrencyCodes.BDT, "050", "Bangladeshi taka"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
