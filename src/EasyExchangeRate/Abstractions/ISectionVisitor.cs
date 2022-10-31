using EasyExchangeRate.Abstraction;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstractions
{
    public interface ISectionVisitor
    {
        public IConfigurationSection Section { get; }
        public IExchangeRateAdapter Adapter { get; }
    }
}
