namespace EasyExchangeRate.Common
{
    public class ShpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ShpCurrency()
        {
            Info = EasyCurrency.From(("£", CurrencyCodes.SHP, "654", "Saint Helena pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
