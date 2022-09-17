namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mop Currency
    /// </summary>
    public class MopCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MopCurrency()
        {
            Info = Currency.From(("MOP", CurrencyCodes.MOP, "446", "Macanese Pataca", "仙"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
