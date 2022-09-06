namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Bob Currency
    /// </summary>
    public class BobCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BobCurrency()
        {
            Info = EasyCurrency.From(("Bs", CurrencyCodes.BOB, "068", "Bolivian boliviano"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
