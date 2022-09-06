namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Kyd Currency
    /// </summary>
    public class KydCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static KydCurrency()
        {
            Info = EasyCurrency.From(("$", CurrencyCodes.KYD, "136", "Cayman Islands dollar"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
