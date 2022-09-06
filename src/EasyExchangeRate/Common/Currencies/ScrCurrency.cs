namespace EasyExchangeRate.Common
{
    public class ScrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ScrCurrency()
        {
            Info = EasyCurrency.From(("SCR", CurrencyCodes.SCR, "690", "Seychelles rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
