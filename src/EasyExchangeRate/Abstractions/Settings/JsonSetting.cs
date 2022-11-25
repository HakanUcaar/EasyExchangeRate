using EasyExchangeRate.Abstractions;
using Optionable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate
{
    public class JsonSetting : IOption
    {
        public string DateFormat { get; set; } = "yyyy-MM-dd HH:mm:ss";
    }
}
