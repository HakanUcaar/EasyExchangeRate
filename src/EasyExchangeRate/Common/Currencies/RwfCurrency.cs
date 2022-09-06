namespace EasyExchangeRate.Common
{
    public class RwfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static RwfCurrency()
        {
            Info = EasyCurrency.From(("RF", CurrencyCodes.RWF, "646", "Rwandan Franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
