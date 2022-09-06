namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Idr Currency
    /// </summary>
    public class IdrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static IdrCurrency()
        {
            Info= EasyCurrency.From(("Rp", CurrencyCodes.IDR, "360", "Indonesian Rupiah"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
