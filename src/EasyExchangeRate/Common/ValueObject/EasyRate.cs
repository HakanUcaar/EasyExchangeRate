using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class EasyRate : EasyValueOf<(EasyMoney Money, EasyCurrency TargetCurrency), EasyRate>
    {
        public EasyCurrency TargetCurrency => Value.TargetCurrency;
        public EasyMoney Money => Value.Money;

        public override string ToString()
        {
            return $"{Value.Money.Value.Amount}{Value.Money.Value.Currency.Value.Symbol}";
        }
        protected static bool Equal(EasyRate a, EasyRate b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Money.Value.Currency.Value.Symbol == b.Value.Money.Value.Currency.Value.Symbol;
        }
        public static EasyMoney operator *(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Money.Value.Amount * b), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator +(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Money.Value.Amount + b), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator -(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Money.Value.Amount - b), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator /(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Value.Money.Value.Amount / b), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator +(EasyRate a, EasyRate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Money.Value.Amount + b.Value.Money.Value.Amount), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator -(EasyRate a, EasyRate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Money.Value.Amount - b.Value.Money.Value.Amount), a.Value.Money.Value.Currency));
        }
        public static EasyMoney operator /(EasyRate a, EasyRate b)
        {
            //if (!Equal(a, b))
            //{
            //    throw new NotEqualMoneyCurrencyException();
            //}

            return EasyMoney.From((((a.Value.Money.Value.Amount / b.Value.Money.Value.Amount)), b.Value.TargetCurrency));
        }
    }
}
