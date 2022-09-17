namespace EasyExchangeRate.Common
{
    public class RubCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static RubCurrency()
        {
            Info = Currency.From(("₽", CurrencyCodes.RUB, "643", "Russian Ruble", "копейка"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
