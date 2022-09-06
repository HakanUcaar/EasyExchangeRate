namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cny Currency
    /// </summary>
    public class CnyCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CnyCurrency()
        {
            Info = EasyCurrency.From(("¥", CurrencyCodes.CNY, "156", "Renminbi"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
