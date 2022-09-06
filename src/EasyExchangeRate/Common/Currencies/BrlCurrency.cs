namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Brl Currency
    /// </summary>
    public class BrlCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BrlCurrency()
        {
            Info = EasyCurrency.From(("R$", CurrencyCodes.BRL, "986", "Brazilian real"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
