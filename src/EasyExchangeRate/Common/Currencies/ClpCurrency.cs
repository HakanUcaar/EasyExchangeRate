namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Clp Currency
    /// </summary>
    public class ClpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static ClpCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.CLP, "152", "Chilean peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
