namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mur Currency
    /// </summary>
    public class MurCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MurCurrency()
        {
            Info = EasyCurrency.From(("₨", CurrencyCodes.MUR, "480", "Mauritian rupee"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
