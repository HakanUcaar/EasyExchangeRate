namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Uah Currency
    /// </summary>
    public class UahCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static UahCurrency()
        {
            Info = Currency.From(("₴", CurrencyCodes.UAH, "980", "Ukrainian Hryvnia", "kopiyka"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
