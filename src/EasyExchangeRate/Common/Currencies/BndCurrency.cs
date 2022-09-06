namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bnd Currency
    /// </summary>
    public class BndCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BndCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.BND, "096", "Brunei dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
