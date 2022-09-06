namespace EasyExchangeRate.Common
{
    public class PhpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PhpCurrency()
        {
            Info = EasyCurrency.From(("₱", CurrencyCodes.PHP, "608", "Philippine Piso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
