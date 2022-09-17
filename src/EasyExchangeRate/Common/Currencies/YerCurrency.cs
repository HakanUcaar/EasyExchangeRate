namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Yer Currency
    /// </summary>
    public class YerCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static YerCurrency()
        {
            Info = Currency.From(("ر.ي.", CurrencyCodes.YER, "886", "Yemeni Rial", "fils"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
