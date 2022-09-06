namespace EasyExchangeRate.Common
{
    public class PygCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PygCurrency()
        {
            Info = EasyCurrency.From(("₲", CurrencyCodes.PYG, "600", "Paraguayan Guarani"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
