namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Isk Currency
    /// </summary>
    public class IskCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static IskCurrency()
        {
            Info = EasyCurrency.From(("kr", CurrencyCodes.ISK, "352", "Icelandic Króna"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
