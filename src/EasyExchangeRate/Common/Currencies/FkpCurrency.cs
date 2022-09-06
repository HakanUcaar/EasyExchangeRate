namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Fkp Currency
    /// </summary>
    public class FkpCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static FkpCurrency()
        {
            Info = EasyCurrency.From(("£", CurrencyCodes.FKP, "238", "Falkland Islands pound"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
