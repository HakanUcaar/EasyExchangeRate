namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Inr Currency
    /// </summary>
    public class InrCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static InrCurrency()
        {
            Info = EasyCurrency.From(("₹", CurrencyCodes.INR, "356", "Indian Rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
