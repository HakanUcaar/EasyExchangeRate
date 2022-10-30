using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Extensions
{
    public static class OptionExtension
    {
        public static IExchangeRateAdapter AddOption<T>(this IExchangeRateAdapter adapter, Action<T> option) where T : IOption
        {
            var optInstance = Activator.CreateInstance<T>();
            option(optInstance);
            adapter.Options.Add(optInstance);
            return adapter;
        }

        public static T GetOption<T>(this IExchangeRateAdapter adapter) where T : IOption
        {             
            return (T)adapter.Options.FirstOrDefault(x => x.GetType() == typeof(T));
        }
    }
}
