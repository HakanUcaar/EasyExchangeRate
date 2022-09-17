using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class AustraliaAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Reserve Bank Of Australia",
            Url = "http://www.rba.gov.au/rss/rss-cb-exchange-rates.xml",
            Unit = 1
        };

        public override Currency BaseCurrency => AudCurrency.Info;
        public AustraliaAdapter()
        {
            AddCurrency(UsdCurrency.Info);
            AddCurrency(CnyCurrency.Info);
            AddCurrency(JpyCurrency.Info);
            AddCurrency(EurCurrency.Info);
            AddCurrency(KrwCurrency.Info);
            AddCurrency(SgdCurrency.Info);
            AddCurrency(NzdCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(MyrCurrency.Info);
            AddCurrency(ThbCurrency.Info);
            AddCurrency(IdrCurrency.Info);
            AddCurrency(InrCurrency.Info);
            AddCurrency(TwdCurrency.Info);
            AddCurrency(VndCurrency.Info);
            AddCurrency(HkdCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(CadCurrency.Info);
            AddCurrency(XdrCurrency.Info);
        }

        public override List<Rate> GetRates()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Source.Url);
            var namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
            namespaceManager.AddNamespace("cb", "http://www.cbwiki.net/wiki/index.php/Specification_1.2/");

            XmlNodeList nodes = xmlDoc.SelectNodes("//cb:exchangeRate", namespaceManager);

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.IsoCode.ToString() == node.SelectSingleNode("cb:targetCurrency", namespaceManager).InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("cb:observation/cb:value", namespaceManager).InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;

                        Rates.Add(Rate.From((Money.From((rate, BaseCurrency)), currency)));
                        //this.Rates.Add(EasyMoney.From((rate, currency)));
                    });
                }
            }

            return Rates;
        }
    }
}
