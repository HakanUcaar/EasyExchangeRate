namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ars Currency
    /// </summary>
    public class ArsCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ArsCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.ARS, "032", "Argentine peso"));
        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
