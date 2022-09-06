namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Iqd Currency
    /// </summary>
    public class IqdCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static IqdCurrency()
        {
            Info = EasyCurrency.From(("د.ع.", CurrencyCodes.IQD, "368", "Iraqi Dinar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
