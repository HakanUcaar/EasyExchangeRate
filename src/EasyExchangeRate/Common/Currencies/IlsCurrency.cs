namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ils Currency
    /// </summary>
    public class IlsCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static IlsCurrency()
        {
            Info =  Currency.From(("₪", CurrencyCodes.ILS, "376", "Israeli New Shekel", "agora"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
