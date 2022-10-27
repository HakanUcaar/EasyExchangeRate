using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class EuropeAdapter : AbstractExchangeRateAdapter
    {        
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "European Central Bank",
            Url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml",
            Unit = 1
        };

        public override Currency BaseCurrency => EurCurrency.Info;
        public EuropeAdapter()
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

        public override List<Rate> GetRates()
        {
            var dataSetting = (DataSetting)Options.FirstOrDefault(x => x.GetType() == typeof(DataSetting));

            var rates = new List<Rate>();
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@currency]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.IsoCode.ToString() == node.Attributes["currency"].Value).Do(currency =>
                    {
                        var rate = Decimal.Parse(node.Attributes["rate"].Value, NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
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
