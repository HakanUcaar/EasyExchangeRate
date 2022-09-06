using EasyExchangeRate.Adapter;

namespace EasyExchangeRate
{
    public static class ExchangeRate
    {
        public static readonly TurkeyAdapter TurkeyAdapter;
        public static readonly EuropeAdapter EuropeAdapter;
        public static readonly DenmarkAdapter DenmarkAdapter;
        public static readonly IsraelAdapter IsraelAdapter;
        public static readonly RussiaAdapter RussiaAdapter;
        public static readonly CanadaAdapter CanadaAdapter;
        public static readonly AustraliaAdapter AustraliaAdapter;
        public static readonly PolandAdapter PolandAdapter;
        

        static ExchangeRate()
        {
            TurkeyAdapter = new TurkeyAdapter();
            EuropeAdapter = new EuropeAdapter();
            DenmarkAdapter = new DenmarkAdapter();
            IsraelAdapter = new IsraelAdapter();
            RussiaAdapter = new RussiaAdapter();
            AustraliaAdapter = new AustraliaAdapter();
            PolandAdapter = new PolandAdapter();
        }
        

    }
}
