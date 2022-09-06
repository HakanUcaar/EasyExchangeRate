namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lyd Currency
    /// </summary>
    public class LydCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LydCurrency()
        {
            Info = EasyCurrency.From(("د.ل.", CurrencyCodes.LYD, "434", "Libyan Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
