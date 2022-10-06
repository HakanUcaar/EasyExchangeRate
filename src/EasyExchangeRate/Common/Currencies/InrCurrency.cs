using EasyExchangeRate.Common;

namespace EasyExchangeRate
{
    /// <summary>
    /// Inr Currency
    /// </summary>
    public class InrCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static InrCurrency()
        {
            Info = Currency.From(("₹", CurrencyCodes.INR, "356", "Indian Rupee", "Paisa"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
