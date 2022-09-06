namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Zwl Currency
    /// </summary>
    public class ZwlCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ZwlCurrency()
        {
            Info = EasyCurrency.From(("", CurrencyCodes.ZWL, "932", "Zimbabwean dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
