using EasyExchangeRate.Abstraction;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstractions
{
    public class SectionVisitor : ISectionVisitor
    {
        private readonly IConfigurationSection _section;
        private readonly IExchangeRateAdapter _adapter;
        public SectionVisitor(IExchangeRateAdapter adapter, IConfigurationSection section)
        {
            _section = section;
            _adapter = adapter;
        }
        public IConfigurationSection Section => _section;
        public IExchangeRateAdapter Adapter => _adapter;
    }
}
