using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

        public override Currency BaseCurrency => IlsCurrency.Info;
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

        public override List<Rate> GetRates()
        {
            var dataSetting = (DataSetting)Options.FirstOrDefault(x => x.GetType() == typeof(DataSetting));

            var rates = new List<Rate>();
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//CURRENCY");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.IsoCode.ToString() == node.SelectSingleNode("CURRENCYCODE").InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("RATE").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
                        rates.Add(Rate.From((DateTime.Now, Money.From((dataSetting is not null ? Math.Round(rate, dataSetting.RateDigit) : rate, BaseCurrency)), currency)));
                    });
                }
            }

            return rates;
        }

        public override List<Rate> GetRates(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
