namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bov Currency
    /// </summary>
    public class BovCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BovCurrency()
        {
            Info = EasyCurrency.From(("", CurrencyCodes.BOV, "984", "Bolivian Mvdol (funds code)"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
