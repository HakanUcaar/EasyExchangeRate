﻿using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class IsraelAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Bank Of Israel",
            Url = "https://www.boi.org.il/currency.xml",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => IlsCurrency.Info;
        public IsraelAdapter()
        {
            AddCurrency(UsdCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(JpyCurrency.Info);
            AddCurrency(EurCurrency.Info);
            AddCurrency(AudCurrency.Info);
            AddCurrency(CadCurrency.Info);
            AddCurrency(DkkCurrency.Info);
            AddCurrency(NokCurrency.Info);
            AddCurrency(ZarCurrency.Info);
            AddCurrency(SekCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(JodCurrency.Info);
            AddCurrency(LbpCurrency.Info);
            AddCurrency(EgpCurrency.Info);
        }

        public override List<EasyRate> GetRates()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//CURRENCY");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.SelectSingleNode("CURRENCYCODE").InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("RATE").InnerText;
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
