namespace EasyExchangeRate.Common
{
    public class SrdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SrdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.SRD, "968", "Surinamese dollarc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
