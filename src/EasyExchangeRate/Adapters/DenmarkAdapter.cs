﻿using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class DenmarkAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Danmarks Nationalbank",
            Url = "https://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=da",
            Unit = 100
        };

        public override EasyCurrency BaseCurrency => DkkCurrency.Info;
        public DenmarkAdapter()
        {
            AddCurrency(UsdCurrency.Info);
            AddCurrency(JpyCurrency.Info);
            AddCurrency(BgnCurrency.Info);
            AddCurrency(CzkCurrency.Info);
            AddCurrency(DkkCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(HufCurrency.Info);
            AddCurrency(PlnCurrency.Info);
            AddCurrency(RonCurrency.Info);
            AddCurrency(SekCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(IskCurrency.Info);
            AddCurrency(NokCurrency.Info);
            AddCurrency(HrkCurrency.Info);
            AddCurrency(TryCurrency.Info);
            AddCurrency(AudCurrency.Info);
            AddCurrency(BrlCurrency.Info);
            AddCurrency(CadCurrency.Info);
            AddCurrency(CnyCurrency.Info);
            AddCurrency(HkdCurrency.Info);
            AddCurrency(IdrCurrency.Info);
            AddCurrency(IlsCurrency.Info);
            AddCurrency(InrCurrency.Info);
            AddCurrency(KrwCurrency.Info);
            AddCurrency(MxnCurrency.Info);
            AddCurrency(MyrCurrency.Info);
            AddCurrency(NzdCurrency.Info);
            AddCurrency(PhpCurrency.Info);
            AddCurrency(SgdCurrency.Info);
            AddCurrency(ThbCurrency.Info);
            AddCurrency(ZarCurrency.Info);
        }

        public override List<EasyRate> GetRates()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@code]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.Attributes["code"].Value).Do(currency =>
                    {
                        var rate = Decimal.Parse(node.Attributes["rate"].Value.Replace(",", "."), NumberStyles.Currency, new CultureInfo("en-Us")) / Source.Unit;
                        //this.Rates.Add(EasyMoney.From((rate, currency)));
                        Rates.Add(EasyRate.From((EasyMoney.From((rate, BaseCurrency)), currency)));
                    });
                }
            }

            return Rates;
        }
    }
}
