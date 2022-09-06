﻿using EasyExchangeRate.Abstraction;
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
    public class CanadaAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Bank of Canada",
            Url = "https://www.bankofcanada.ca/valet/fx_rss/",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => CadCurrency.Info;
        public CanadaAdapter()
        {
            AddCurrency(AudCurrency.Info);
            AddCurrency(BrlCurrency.Info);
            AddCurrency(CnyCurrency.Info);
            AddCurrency(EurCurrency.Info);
            AddCurrency(HkdCurrency.Info);
            AddCurrency(InrCurrency.Info);
            AddCurrency(IdrCurrency.Info);
            AddCurrency(JpyCurrency.Info);
            AddCurrency(MxnCurrency.Info);
            AddCurrency(NzdCurrency.Info);
            AddCurrency(NokCurrency.Info);
            AddCurrency(PenCurrency.Info);
            AddCurrency(RubCurrency.Info);
            AddCurrency(SarCurrency.Info);
            AddCurrency(SgdCurrency.Info);
            AddCurrency(ZarCurrency.Info);
            AddCurrency(KrwCurrency.Info);
            AddCurrency(SekCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(TwdCurrency.Info);
            AddCurrency(TryCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(UsdCurrency.Info);
        }

        public override List<EasyRate> GetRates()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Source.Url);
            var namespaceManager = new XmlNamespaceManager(xmlDoc.NameTable);
            namespaceManager.AddNamespace("cb", "http://www.cbwiki.net/wiki/index.php/Specification_1.1");

            XmlNodeList nodes = xmlDoc.SelectNodes("//cb:exchangeRate", namespaceManager);

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.SelectSingleNode("cb:targetCurrency", namespaceManager).InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("cb:value", namespaceManager).InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;

                        //this.Rates.Add(EasyMoney.From((rate, currency)));
                        Rates.Add(EasyRate.From((EasyMoney.From((rate, BaseCurrency)), currency)));
                    });
                }
            }

            return Rates;
        }
    }
}
