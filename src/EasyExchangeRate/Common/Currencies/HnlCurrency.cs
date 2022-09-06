namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Hnl Currency
    /// </summary>
    public class HnlCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static HnlCurrency()
        {
            Info = EasyCurrency.From(("L", CurrencyCodes.HNL, "340", "Honduran Lempira"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
