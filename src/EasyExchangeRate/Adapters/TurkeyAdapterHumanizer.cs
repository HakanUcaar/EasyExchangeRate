using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Adapter
{

    public class DynamicResult
    {
        public List<EasyRate> Rates { get; set; } = new List<EasyRate>();
        public EasyRate BaseRate { get; set; }
        public List<EasyRate> TargetRates { get; set; } = new List<EasyRate>();
        public object Currencies { get; set; }
    }

    public class TurkeyAdapterHumanizer: DynamicObject
    {
        String[] RateKeys = new String[] { "DövizKuru", "Kur", "Döviz", "NeKadar" };
        String[] ExhangeKeys = new String[] { "Çevir", "KaçPara", "NeKadar", "Kaç" };
        public DynamicResult Result { get; set; }

        public static dynamic New()
        {
            return new TurkeyAdapterHumanizer();
        }

        public TurkeyAdapterHumanizer()
        {

        }

        public TurkeyAdapterHumanizer(DynamicResult res = null)
        {
            Result = res;
        }

        private TurkeyAdapterHumanizer Build(EasyRate rate = null, List<EasyCurrency> currencies = null)
        {
            if (Result.IsNull())
            {
                Result = new DynamicResult();
            }

            Result.Currencies = currencies;
            if(Result.BaseRate.IsNotNull()) 
            {
                Result.TargetRates.Add(rate);
            }
            Result.BaseRate = Result.BaseRate ?? rate;

            return new TurkeyAdapterHumanizer(Result);
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            bool resultCode = false;
            result = null;

            if(RateKeys.Any(x=>x == binder.Name))
            {
                if(Result.TargetRates.Count > 0)
                {
                    Result.TargetRates.Add(Result.BaseRate);
                    result = Result.TargetRates;
                }
                else
                {
                    result = Result.BaseRate;
                }
                
                resultCode = true;
            }
            else
            if (ExhangeKeys.Any(x => x == binder.Name))
            {
                if(Result.BaseRate.IsNotNull() && Result.TargetRates.Count() > 0)
                {
                    Result.Rates.Clear();
                    Result.TargetRates.ForEach(rate =>
                    {
                        Result.Rates.Add(ExchangeRate.TurkeyAdapter.HowMuch(Result.BaseRate.TargetCurrency.IsoCode, rate.TargetCurrency.IsoCode, 1));
                    });                 
                }

                result = Result.Rates;
                resultCode = true;
            }
            else
            if (ExchangeRate.TurkeyAdapter.Currencies.Any(x => x.Symbol == binder.Name))
            {
                var currency = ExchangeRate.TurkeyAdapter.Currencies.FirstOrDefault(x => x.Symbol == binder.Name);
                result = Build(ExchangeRate.TurkeyAdapter.GetRate(currency));
                resultCode = true;
            }
            else
            if (ExchangeRate.TurkeyAdapter.Currencies.Any(x => x.Name == binder.Name))
            {
                var currency = ExchangeRate.TurkeyAdapter.Currencies.FirstOrDefault(x => x.Name == binder.Name);
                result = Build(ExchangeRate.TurkeyAdapter.GetRate(currency));
                resultCode = true;
            }
            else
            if (ExchangeRate.TurkeyAdapter.Currencies.Any(x => x.IsoCode.ToString() == binder.Name))
            {
                var currency = ExchangeRate.TurkeyAdapter.Currencies.FirstOrDefault(x => x.IsoCode.ToString() == binder.Name);
                result = Build(ExchangeRate.TurkeyAdapter.GetRate(currency));
                resultCode = true;
            }
            else
            if (ExchangeRate.TurkeyAdapter.Currencies.Any(x => x.NumericCode == binder.Name))
            {
                var currency = ExchangeRate.TurkeyAdapter.Currencies.FirstOrDefault(x => x.NumericCode == binder.Name);
                result = Build(ExchangeRate.TurkeyAdapter.GetRate(currency));
                resultCode = true;
            }

            return resultCode;
        }
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Result.BaseRate;
            return true;
        }

    }
}
