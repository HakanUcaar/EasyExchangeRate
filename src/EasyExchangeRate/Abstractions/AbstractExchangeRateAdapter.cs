using EasyExchangeRate.Common;
using EasyExchangeRate.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstraction
{
    public abstract class AbstractExchangeRateAdapter : IExchangeRateAdapter
    {
        public List<Currency> Currencies { get; protected set; } = new List<Currency>();
        public virtual List<Rate> Rates { get; protected set; } = new List<Rate>();

        public DateTime UpdateDate { get; protected set; }
        public virtual Currency BaseCurrency { get; }
        public virtual SourceInfo Source { get; }

        public void AddCurrency(Currency currency)
        {
            Currencies.Add(currency);
        }

        public abstract List<Rate> GetRates();
        public string GetJsonRates()
        {
            return JsonConvert.SerializeObject(GetRates(),Formatting.Indented);
        }
        public virtual Rate GetRate(Currency currency)
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
        public virtual Rate GetRate(CurrencyCodes isoCode)
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var money = Rates.FirstOrDefault(x => x.Value.TargetCurrency.IsoCode == isoCode);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }

        public virtual Rate HowMuch<Source, Target>(decimal amount) where Source : ICurrency
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

            return Rate.From((money, sourceMoney.Value.TargetCurrency));
        }
        public virtual Rate HowMuch(CurrencyCodes source , CurrencyCodes target,  decimal amount) 
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.IsoCode == source);
            var targetMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.IsoCode == target);
            
            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((money, sourceMoney.TargetCurrency));
        }
        public virtual Rate HowMuch(string sourceCode, string targetCode, decimal amount)
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.IsoCode == sourceCode.ToEnum<CurrencyCodes>());
            var targetMoney = Rates.FirstOrDefault(x => x.Value.TargetCurrency.IsoCode == targetCode.ToEnum<CurrencyCodes>());

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((money, sourceMoney.Value.TargetCurrency));
        }
    }
}
