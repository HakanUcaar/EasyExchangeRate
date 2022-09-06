namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Lsl Currency
    /// </summary>
    public class LslCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static LslCurrency()
        {
            Info = EasyCurrency.From(("L", CurrencyCodes.LSL, "426", "Lesotho loti"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
