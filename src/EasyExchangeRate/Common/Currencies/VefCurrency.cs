namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Vef Currency
    /// </summary>
    public class VefCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static VefCurrency()
        {
            Info = Currency.From(("Bs.S", CurrencyCodes.VEF, "937", "Venezuelan bolívar fuerte", "céntimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
