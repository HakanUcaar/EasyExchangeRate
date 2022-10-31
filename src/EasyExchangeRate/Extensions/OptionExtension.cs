using EasyExchangeRate.Abstraction;
using EasyExchangeRate.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using EasyExchangeRate.Exceptions;

namespace EasyExchangeRate.Extensions
{
    public static class OptionExtension
    {
        public static IExchangeRateAdapter AddOption<T>(this IExchangeRateAdapter adapter, Action<T> option) where T : IOption
        {
            if (adapter is null)
            {
                throw new NullException(nameof(adapter));
            }

            var optInstance = Activator.CreateInstance<T>();
            option(optInstance);
            adapter.Options.Add(optInstance);
            
            return adapter;
        }

        public static T GetOption<T>(this IExchangeRateAdapter adapter) where T : IOption
        {
            if (adapter is null)
            {
                throw new NullException(nameof(adapter));
            }

            return (T)adapter.Options.FirstOrDefault(x => x.GetType() == typeof(T));
        }

        public static IExchangeRateAdapter Configure<T>(this IExchangeRateAdapter adapter, IConfigurationSection section) where T : IOption
        {
            if (adapter is null)
            {
                throw new NullException(nameof(adapter));
            }

            if (section is null)
            {
                throw new NullException(nameof(section));
            }

            T? option;
            if(section.GetChildren().Any(x=>x.Key == typeof(T).Name))
            {
                option = section.GetChildren().FirstOrDefault(x => x.Key == typeof(T).Name).Get<T>();
            }
            else
            {
                option = section.Get<T>();
            }
            adapter.Options.Add(option);

            return adapter;
        }

        public static ISectionVisitor UseSection(this IExchangeRateAdapter adapter, IConfigurationSection section)
        {
            if(adapter is null)
            {
                throw new NullException(nameof(adapter));
            }

            if (section is null)
            {
                throw new NullException(nameof(adapter));
            }

            var sectionVisitor = new SectionVisitor(adapter,section);
            return sectionVisitor;
        }

        public static ISectionVisitor Configure<T>(this ISectionVisitor visitor) where T : IOption
        {
            T? option;
            if (visitor.Section.GetChildren().Any(x => x.Key == typeof(T).Name))
            {
                option = visitor.Section.GetChildren().FirstOrDefault(x => x.Key == typeof(T).Name).Get<T>();
            }
            else
            {
                if(visitor.Section.Key != typeof(T).Name)
                {
                    throw new OptionNotFoundException();
                }

                option = visitor.Section.Get<T>();
            }

            visitor.Adapter.Options.Add(option);

            return visitor;
        }
    }
}
