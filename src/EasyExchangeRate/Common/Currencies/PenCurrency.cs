namespace EasyExchangeRate.Common
{
    public class PenCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PenCurrency()
        {
            Info = EasyCurrency.From(("S/", CurrencyCodes.PEN, "604", "Peruvian Sol"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
