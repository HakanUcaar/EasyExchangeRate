namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Thb Currency
    /// </summary>
    public class ThbCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static ThbCurrency()
        {
            Info = Currency.From(("฿", CurrencyCodes.THB, "764", "Thai Baht", "satang"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
