namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Cny Currency
    /// </summary>
    public class CnyCurrency : Currency, ICurrency
    {
        public static readonly Currency Info;
        static CnyCurrency()
        {
            Info = Currency.From(("¥", CurrencyCodes.CNY, "156", "Renminbi", "分"));

        }
        public Currency GetInfo()
        {
            return Info;
        }
    }
}
