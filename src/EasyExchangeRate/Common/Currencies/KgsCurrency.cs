namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kgs Currency
    /// </summary>
    public class KgsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KgsCurrency()
        {
            Info = EasyCurrency.From(("сом", CurrencyCodes.KGS, "417", "Kyrgystani Som"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
