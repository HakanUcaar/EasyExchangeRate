namespace EasyExchangeRate.Common
{
    public class PlnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static PlnCurrency()
        {
            Info = EasyCurrency.From(("zł", CurrencyCodes.PLN, "985", "Polish Zloty"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
