namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Mdl Currency
    /// </summary>
    public class MdlCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static MdlCurrency()
        {
            Info = Currency.From(("L", CurrencyCodes.MDL, "498", "Moldovan Leu", "ban"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
