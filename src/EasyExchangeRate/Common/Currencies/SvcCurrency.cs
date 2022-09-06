namespace EasyExchangeRate.Common
{
    public class SvcCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SvcCurrency()
        {
            Info = EasyCurrency.From(("₡", CurrencyCodes.SVC, "222", "Salvadoran colón"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
