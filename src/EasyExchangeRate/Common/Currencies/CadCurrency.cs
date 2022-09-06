namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cad Currency
    /// </summary>
    public class CadCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static CadCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.CAD, "124", "Canadian dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
