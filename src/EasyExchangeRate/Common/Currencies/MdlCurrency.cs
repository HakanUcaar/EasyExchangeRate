namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mdl Currency
    /// </summary>
    public class MdlCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static MdlCurrency()
        {
            Info = EasyCurrency.From(("L", CurrencyCodes.MDL, "498", "Moldovan Leu"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
