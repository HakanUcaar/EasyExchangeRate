using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
using EasyExchangeRate.Extensions;
using Optionable;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EasyExchangeRate.Adapter
{
    public class PolandAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "National Bank of Poland",
            Url = "http://www.nbp.pl/kursy/xml/LastA.xml",
            Unit = 1
        };

        public override Currency BaseCurrency => PlnCurrency.Info;
        public PolandAdapter()
        {
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);

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

        public override List<Rate> GetRates()
        {
            var dataSetting = this.GetOption<DataSetting>();

            var rates = new List<Rate>();
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//pozycja");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.IsoCode.ToString() == node.SelectSingleNode("kod_waluty").InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("kurs_sredni").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val.Replace(",", ".")), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
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
