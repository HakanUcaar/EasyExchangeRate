namespace EasyExchangeRate.Common
{
    public class PhpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static PhpCurrency()
        {
            Info = Currency.From(("₱", CurrencyCodes.PHP, "608", "Philippine Piso", "sentimo"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
