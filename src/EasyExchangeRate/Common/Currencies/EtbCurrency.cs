namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Etb Currency
    /// </summary>
    public class EtbCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static EtbCurrency()
        {
            Info = EasyCurrency.From(("ብር", CurrencyCodes.ETB, "230", "Ethiopian birr"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
