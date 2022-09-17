namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bov Currency
    /// </summary>
    public class BovCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static BovCurrency()
        {
            Info = Currency.From(("", CurrencyCodes.BOV, "984", "Bolivian Mvdol (funds code)", "senti"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
