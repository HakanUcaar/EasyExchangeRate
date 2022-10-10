﻿using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
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
        public abstract List<Rate> GetRates(DateTime date);
        public virtual List<List<Rate>> GetRates(DateRange dateRange)
        {
            var rates = new List<List<Rate>>();
            dateRange.ToDateList().ForEach(date => { rates.Add(GetRates(date)); });
            return rates;
        }
        public virtual List<List<Rate>> GetRates(int dayCount)
        {
            var rates = new List<List<Rate>>();
            var dateRange = DateRange.From((DateTime.Now.AddDays(-dayCount), DateTime.Now));
            dateRange.ToDateList().ForEach(date => { rates.Add(GetRates(date)); });
            return rates;
        }
        public string GetJsonRates()
        {
            return JsonConvert.SerializeObject(GetRates(),Formatting.Indented);
        }
        public string GetJsonRates(DateRange dateRange)
        {
            return JsonConvert.SerializeObject(GetRates(dateRange), Formatting.Indented);
        }
        public string GetJsonRates(int dayCount)
        {
            return JsonConvert.SerializeObject(GetRates(dayCount), Formatting.Indented);
        }

        public virtual Rate GetRate(Currency currency)
        {
            var rates = GetRates();

            var money = rates.FirstOrDefault(x => x.TargetCurrency == currency);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }
        public virtual Rate GetRate(Currency currency, DateTime date)
        {
            var rates = GetRates(date);

            var money = rates.FirstOrDefault(x => x.TargetCurrency == currency);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }
        public virtual Rate GetRate(CurrencyCodes isoCode)
        {
            var rates = GetRates();

            var money = Rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == isoCode);
            if (money.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            return money;
        }
        public virtual Rate GetRate(CurrencyCodes isoCode, DateTime date)
        {
            var rates = GetRates(date);

            var money = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == isoCode);
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

            var sourceMoney = Rates.FirstOrDefault(x => x.TargetCurrency == sourceCurrency);
            var targetMoney = Rates.FirstOrDefault(x => x.TargetCurrency == targetCurrency);

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;            

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
        public virtual Rate HowMuch(CurrencyCodes source , CurrencyCodes target,  decimal amount) 
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceMoney = Rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == source);
            var targetMoney = Rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == target);
            
            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
        public virtual Rate HowMuch(string sourceCode, string targetCode, decimal amount)
        {
            if (!Rates.Any())
            {
                GetRates();
            }

            var sourceMoney = Rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == sourceCode.ToEnum<CurrencyCodes>());
            var targetMoney = Rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == targetCode.ToEnum<CurrencyCodes>());

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
    }
}
