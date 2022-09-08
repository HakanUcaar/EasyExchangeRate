using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class EasyRate : EasyValueOf<(EasyMoney money, EasyCurrency targetCurrency), EasyRate>
    {
        public EasyCurrency TargetCurrency => Value.targetCurrency;
        public EasyMoney Money => Value.money;

        public override string ToString()
        {
            return $"{Money.Amount} {Money.Currency.IsoCode}";
        }
        protected static bool Equal(EasyRate a, EasyRate b)
        {
            if (a is null || b is null)
                return false;

            return a.Money.Currency.Symbol == b.Money.Currency.Symbol;
        }
        public static EasyMoney operator *(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Money.Amount * b), a.TargetCurrency));
        }
        public static EasyMoney operator +(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Money.Amount + b), a.TargetCurrency));
        }
        public static EasyMoney operator -(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Money.Amount - b), a.TargetCurrency));
        }
        public static EasyMoney operator /(EasyRate a, Decimal b)
        {
            return EasyMoney.From(((a.Money.Amount / b), a.TargetCurrency));
        }
        public static EasyMoney operator +(EasyRate a, EasyRate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Money.Amount + b.Money.Amount), a.Money.Currency));
        }
        public static EasyMoney operator -(EasyRate a, EasyRate b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Money.Amount - b.Money.Amount), a.Money.Currency));
        }
        public static EasyMoney operator /(EasyRate a, EasyRate b)
        {
            //if (!Equal(a, b))
            //{
            //    throw new NotEqualMoneyCurrencyException();
            //}

            return EasyMoney.From((((a.Money.Amount / b.Money.Amount)), b.TargetCurrency));
        }
    }
}
