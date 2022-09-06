namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ngn Currency
    /// </summary>
    public class NgnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static NgnCurrency()
        {
            Info = EasyCurrency.From(("₦", CurrencyCodes.NGN, "566", "Nigerian Naira"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
