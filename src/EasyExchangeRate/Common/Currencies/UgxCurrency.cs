namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Ugx Currency
    /// </summary>
    public class UgxCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static UgxCurrency()
        {
            Info = EasyCurrency.From(("USh", CurrencyCodes.UGX, "800", "Ugandan shilling"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
