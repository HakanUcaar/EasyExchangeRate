namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Dop Currency
    /// </summary>
    public class DopCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static DopCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.DOP, "214", "Dominican peso"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
