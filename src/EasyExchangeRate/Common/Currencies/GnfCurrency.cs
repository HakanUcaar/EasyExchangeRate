namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Gnf Currency
    /// </summary>
    public class GnfCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static GnfCurrency()
        {
            Info = EasyCurrency.From(("FG", CurrencyCodes.GNF, "324", "Guinean franc"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
