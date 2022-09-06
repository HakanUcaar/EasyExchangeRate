namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Nio Currency
    /// </summary>
    public class NioCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NioCurrency()
        {
            Info = EasyCurrency.From(("C$", CurrencyCodes.NIO, "558", "Nicaraguan Córdoba"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
