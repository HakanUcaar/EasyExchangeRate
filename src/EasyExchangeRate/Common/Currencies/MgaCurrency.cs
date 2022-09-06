namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mga Currency
    /// </summary>
    public class MgaCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MgaCurrency()
        {
            Info = EasyCurrency.From(("Ar", CurrencyCodes.MGA, "969", "Malagasy ariary"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
