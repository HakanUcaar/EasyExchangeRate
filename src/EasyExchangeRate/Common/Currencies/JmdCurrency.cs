namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Jmd Currency
    /// </summary>
    public class JmdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static JmdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.JMD, "388", "Jamaican Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
