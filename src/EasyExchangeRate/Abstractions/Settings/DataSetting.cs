using EasyExchangeRate.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate
{
    public class DataSetting : IOption
    {
        public int RateDigit { get; set; } = 6;
        public TimeZoneInfo TimeZone { get; set; }
    }
}
