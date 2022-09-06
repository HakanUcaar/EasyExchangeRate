namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Uzs Currency
    /// </summary>
    public class UzsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static UzsCurrency()
        {
            Info = EasyCurrency.From(("сўм", CurrencyCodes.UZS, "860", "Uzbekistani Som"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
