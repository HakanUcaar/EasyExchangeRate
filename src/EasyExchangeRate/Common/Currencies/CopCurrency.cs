namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cop Currency
    /// </summary>
    public class CopCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CopCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.COP, "170", "Colombian peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
