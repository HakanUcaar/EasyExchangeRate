namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Yer Currency
    /// </summary>
    public class YerCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static YerCurrency()
        {
            Info = EasyCurrency.From(("ر.ي.", CurrencyCodes.YER, "886", "Yemeni Rial"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
