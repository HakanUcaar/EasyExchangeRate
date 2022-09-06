namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Jod Currency
    /// </summary>
    public class JodCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static JodCurrency()
        {
            Info = EasyCurrency.From(("د.ا.‏", CurrencyCodes.JOD, "400", "Jordanian Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
