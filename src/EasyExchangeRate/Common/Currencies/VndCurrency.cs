namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vnd Currency
    /// </summary>
    public class VndCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static VndCurrency()
        {
            Info = EasyCurrency.From(("₫", CurrencyCodes.VND, "704", "Vietnamese Dong"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
