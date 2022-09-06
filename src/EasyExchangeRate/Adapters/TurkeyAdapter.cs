using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class TurkeyAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Republic of Turkey Central Bank",
            Url = "https://www.tcmb.gov.tr/kurlar/today.xml",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => TryCurrency.Info;
        public TurkeyAdapter()
        {
            AddCurrency(UsdCurrency.Info);
            AddCurrency(AudCurrency.Info);
            AddCurrency(DkkCurrency.Info);
            AddCurrency(EurCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(SekCurrency.Info);
            AddCurrency(CadCurrency.Info);
            AddCurrency(KwdCurrency.Info);
            AddCurrency(NokCurrency.Info);
            AddCurrency(SarCurrency.Info);
            AddCurrency(JpyCurrency.Info);
            AddCurrency(BgnCurrency.Info);
            AddCurrency(RonCurrency.Info);
            AddCurrency(RubCurrency.Info);
            AddCurrency(IrrCurrency.Info);
            AddCurrency(CnyCurrency.Info);
            AddCurrency(PkrCurrency.Info);
            AddCurrency(QarCurrency.Info);
            AddCurrency(KrwCurrency.Info);
            AddCurrency(AznCurrency.Info);
            AddCurrency(AedCurrency.Info);
            AddCurrency(XdrCurrency.Info);
        }

        public sealed override List<EasyRate> GetRates()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@CurrencyCode]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.Attributes["CurrencyCode"].Value).Do(currency =>
                    {
                        var val = node.SelectSingleNode("ForexBuying").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val) , NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;

                        Rates.Add(EasyRate.From((EasyMoney.From((rate,BaseCurrency)), currency)));
                    });
                }
            }

            return Rates;
        }
    }
}
