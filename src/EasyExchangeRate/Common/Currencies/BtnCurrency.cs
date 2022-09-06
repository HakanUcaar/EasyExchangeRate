namespace EasyExchangeRate.Common
{
    /// <summary>
    /// Btn Currency
    /// </summary>
    public class BtnCurrency : EasyCurrency, ICurrency
    {
        public static readonly EasyCurrency Info;
        static BtnCurrency()
        {
            Info = EasyCurrency.From(("Nu.", CurrencyCodes.BTN, "064", "Bhutanese ngultrum"));

        }
        public EasyCurrency GetInfo()
        {
            return Info;
        }
    }
}
