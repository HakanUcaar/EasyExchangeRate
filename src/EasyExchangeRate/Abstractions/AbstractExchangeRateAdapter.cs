using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstraction
{
    public abstract class AbstractExchangeRateAdapter : IExchangeRateAdapter
    {
        public List<EasyCurrency> Currencies { get; protected set; } = new List<EasyCurrency>();
        public virtual List<EasyRate> Rates { get; protected set; } = new List<EasyRate>();

        public DateTime UpdateDate { get; protected set; }
        public virtual EasyCurrency BaseCurrency { get; }
        public virtual SourceInfo Source { get; }

        public void AddCurrency(EasyCurrency currency)
        {
            Currencies.Add(currency);
        }

        public abstract List<EasyRate> GetRates();
        public virtual EasyRate GetRate(EasyCurrency currency)
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var money = Rates.FirstOrDefault(x => x.Value.TargetCurrency == currency);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }
        public virtual EasyRate GetRate(CurrencyCodes isoCode)
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var money = Rates.FirstOrDefault(x => x.Value.TargetCurrency.Value.IsoCode == isoCode);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }

        public virtual EasyRate HowMuch<Source, Target>(decimal amount) where Source : ICurrency
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceCurrency = ((ICurrency)Activator.CreateInstance(typeof(Source))).GetInfo();
            var targetCurrency = ((ICurrency)Activator.CreateInstance(typeof(Target))).GetInfo();

            var sourceMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency == sourceCurrency);
            var targetMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency == targetCurrency);

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;            

            return EasyRate.From((money, sourceMoney.Value.TargetCurrency));
        }
        public virtual EasyRate HowMuch(CurrencyCodes source , CurrencyCodes target,  decimal amount) 
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.Value.IsoCode == source);
            var targetMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.Value.IsoCode == target);
            
            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return EasyRate.From((money, sourceMoney.Value.TargetCurrency));
        }
    }
}
