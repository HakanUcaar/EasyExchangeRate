namespace EasyExchangeRate.Common
{
    public class SbdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SbdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.SBD, "090", "Solomon Islands dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
