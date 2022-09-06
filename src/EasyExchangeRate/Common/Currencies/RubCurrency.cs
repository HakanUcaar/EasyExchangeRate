namespace EasyExchangeRate.Common
{
    public class RubCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static RubCurrency()
        {
            Info = EasyCurrency.From(("₽", CurrencyCodes.RUB, "643", "Russian Ruble"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
