namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vef Currency
    /// </summary>
    public class VefCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static VefCurrency()
        {
            Info = EasyCurrency.From(("Bs.S", CurrencyCodes.VEF, "937", "Venezuelan bolívar fuerte"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
