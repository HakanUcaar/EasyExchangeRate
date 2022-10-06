using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    public class ShpCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ShpCurrency()
        {
            Info = Currency.From(("£", CurrencyCodes.SHP, "654", "Saint Helena pound", "penny"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
