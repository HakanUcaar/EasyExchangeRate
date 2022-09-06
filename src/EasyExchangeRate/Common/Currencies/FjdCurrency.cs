namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Fjd Currency
    /// </summary>
    public class FjdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static FjdCurrency()
        {
            Info = EasyCurrency.From(("FJ$", CurrencyCodes.FJD, "242", "Fiji dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
