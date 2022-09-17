namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Uzs Currency
    /// </summary>
    public class UzsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static UzsCurrency()
        {
            Info = Currency.From(("сўм", CurrencyCodes.UZS, "860", "Uzbekistani Som", "tiyin"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
