namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cup Currency
    /// </summary>
    public class CupCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CupCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.CUP, "192", "Cuban peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
