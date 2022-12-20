using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class Rate : EasyValueOf<(DateTime relaseDate, Money money, Currency targetCurrency), Rate>
    {
        public DateTime RelaseDate => Value.relaseDate;
        public Currency TargetCurrency => Value.targetCurrency;
        public Money Money => Value.money;        

        public dynamic ExtraInfo { get; set; } = new ExpandoObject();

        public override string ToString()
        {
            return $"{Money.Amount}{Money.Currency.Symbol}";
        }
        public string ToString(Action<DisplaySetting> option)
        {
            var setting = new DisplaySetting();
            option(setting);

            string Display(DisplayType displayType) =>
                displayType switch
                {
                    DisplayType.Symbol => Money.Currency.Symbol,
                    DisplayType.Name => $" {Money.Currency.Name}",
                };

            string Rotation(RotationType rotationType) =>
                rotationType switch
                {
                    RotationType.Prefix => $"{Display(setting.Display)}{Money.Amount}",
                    RotationType.Suffix => $"{Money.Amount}{Display(setting.Display)}"                    
                };

            var value = "";
            //TODO It will be add
            switch (setting.Notation)
            {
                case NotationType.Standard:
                    break;
                case NotationType.Compact:
                    break;
                default:
                    break;
            }

            if (setting.CurrencyDisplay)
            {
                value = Rotation(setting.SymbolRotation);
            }
            else
            {
                value = $"{Money.Amount}";
            }          
            
            return value;
        }
        protected static bool Equal(Rate a, Rate b)
        {
            if (a is null || b is null)
                return false;

            return a.Money.Currency.Symbol == b.Money.Currency.Symbol;
        }
        public static Money operator *(Rate a, Decimal b)
        {
            return Money.From(((a.Money.Value.Amount * b), a.Money.Currency));
        }
        public static Money operator +(Rate a, Decimal b)
        {
            return Money.From(((a.Money.Value.Amount + b), a.Money.Currency));
        }
        public static Money operator -(Rate a, Decimal b)
        {
            return Money.From(((a.Money.Value.Amount - b), a.Money.Currency));
        }
        public static Money operator /(Rate a, Decimal b)
        {
            return Money.From(((a.Money.Value.Amount / b), a.Money.Currency));
        }
        public static Money operator +(Rate a, Rate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Money.Value.Amount + b.Money.Amount), a.Money.Currency));
        }
        public static Money operator -(Rate a, Rate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return Money.From(((a.Money.Amount - b.Money.Amount), a.Money.Currency));
        }
        public static Money operator /(Rate a, Rate b)
        {
            //if (!Equal(a, b))
            //{
            //    throw new NotEqualMoneyCurrencyException();
            //}

            return Money.From((((a.Money.Amount / b.Money.Amount)), b.TargetCurrency));
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
