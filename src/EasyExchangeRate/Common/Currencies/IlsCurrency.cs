namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ils Currency
    /// </summary>
    public class IlsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static IlsCurrency()
        {
            Info =  EasyCurrency.From(("₪", CurrencyCodes.ILS, "376", "Israeli New Shekel"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
