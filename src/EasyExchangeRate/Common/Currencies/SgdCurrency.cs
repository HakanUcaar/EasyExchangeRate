namespace EasyExchangeRate.Common
{
    public class SgdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static SgdCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.SGD, "702", "Singapore Dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
