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
    public class RussiaAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Central Bank of Russia",
            Url = "https://www.cbr.ru/scripts/XML_daily.asp",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => RubCurrency.Info;
        public RussiaAdapter()
        {
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);

            AddCurrency(AudCurrency.Info);
            AddCurrency(AznCurrency.Info);
            AddCurrency(GbpCurrency.Info);
            AddCurrency(AmdCurrency.Info);
            AddCurrency(BynCurrency.Info);
            AddCurrency(BgnCurrency.Info);
            AddCurrency(BrlCurrency.Info);
            AddCurrency(HufCurrency.Info);
            AddCurrency(HkdCurrency.Info);
            AddCurrency(DkkCurrency.Info);
            AddCurrency(UsdCurrency.Info);
            AddCurrency(EurCurrency.Info);
            AddCurrency(InrCurrency.Info);
            AddCurrency(KztCurrency.Info);
            AddCurrency(CadCurrency.Info);
            AddCurrency(KgsCurrency.Info);
            AddCurrency(CnyCurrency.Info);
            AddCurrency(MdlCurrency.Info);
            AddCurrency(NokCurrency.Info);
            AddCurrency(PlnCurrency.Info);
            AddCurrency(RonCurrency.Info);
            AddCurrency(XdrCurrency.Info);
            AddCurrency(SgdCurrency.Info);
            AddCurrency(TjsCurrency.Info);
            AddCurrency(TryCurrency.Info);
            AddCurrency(TmtCurrency.Info);
            AddCurrency(UzsCurrency.Info);
            AddCurrency(UahCurrency.Info);
            AddCurrency(CzkCurrency.Info);
            AddCurrency(SekCurrency.Info);
            AddCurrency(ChfCurrency.Info);
            AddCurrency(ZarCurrency.Info);
            AddCurrency(KrwCurrency.Info);
            AddCurrency(JpyCurrency.Info);
        }

        public override List<EasyRate> GetRates()
        {
            var doc = new XmlDocument();
            doc.Load(@Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@ID]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.SelectSingleNode("CharCode").InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("Value").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val.Replace(",", ".")), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
                        //this.Rates.Add(EasyMoney.From((rate, currency)));
                        Rates.Add(EasyRate.From((EasyMoney.From((rate, BaseCurrency)), currency)));
                    });
                }
            }

            return Rates;
        }
    }
}
