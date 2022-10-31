using EasyExchangeRate.Abstractions;
using EasyExchangeRate.Common;
using EasyExchangeRate.Common.ValueObject;
using EasyExchangeRate.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstraction
{
    public abstract class AbstractExchangeRateAdapter : IExchangeRateAdapter
    {
        public List<IOption> Options { get; set; } = new List<IOption>();
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
            var jsonSetting = this.GetOption<JsonSetting>();
            return JsonConvert.SerializeObject(GetRates(),Formatting.Indented, new IsoDateTimeConverter() { DateTimeFormat = jsonSetting.DateFormat });
        }
        public string GetJsonRates(DateRange dateRange)
        {
            var jsonSetting = this.GetOption<JsonSetting>();
            return JsonConvert.SerializeObject(GetRates(dateRange), Formatting.Indented, new IsoDateTimeConverter() { DateTimeFormat = jsonSetting.DateFormat });
        }
        public string GetJsonRates(int dayCount)
        {
            var jsonSetting = this.GetOption<JsonSetting>();
            return JsonConvert.SerializeObject(GetRates(dayCount), Formatting.Indented, new IsoDateTimeConverter() { DateTimeFormat = jsonSetting.DateFormat });
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

            var money = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == isoCode);
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
            var rates = GetRates();

            var sourceCurrency = ((ICurrency)Activator.CreateInstance(typeof(Source))).GetInfo();
            var targetCurrency = ((ICurrency)Activator.CreateInstance(typeof(Target))).GetInfo();

            var sourceMoney = rates.FirstOrDefault(x => x.TargetCurrency == sourceCurrency);
            var targetMoney = rates.FirstOrDefault(x => x.TargetCurrency == targetCurrency);

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;            

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
        public virtual Rate HowMuch(CurrencyCodes source , CurrencyCodes target,  decimal amount) 
        {
            var rates = GetRates();

            var sourceMoney = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == source);
            var targetMoney = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == target);
            
            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
        public virtual Rate HowMuch(string sourceCode, string targetCode, decimal amount)
        {
            var rates = GetRates();

            var sourceMoney = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == sourceCode.ToEnum<CurrencyCodes>());
            var targetMoney = rates.FirstOrDefault(x => x.TargetCurrency.IsoCode == targetCode.ToEnum<CurrencyCodes>());

            if (sourceMoney.IsNull() || targetMoney.IsNull())
            {
                throw new CurrencyNotFoundException();
            }

            var money = (sourceMoney / targetMoney) * amount;

            return Rate.From((DateTime.Now, money, sourceMoney.TargetCurrency));
        }
    }
}
