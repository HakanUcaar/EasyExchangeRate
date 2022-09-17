namespace EasyExchangeRate.Common
{
    public class PlnCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PlnCurrency()
        {
            Info = Currency.From(("zł", CurrencyCodes.PLN, "985", "Polish Zloty", "grosz"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
