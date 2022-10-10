using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common
{
    public class SourceInfo
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string RangeUrl { get; set; }
        public int Unit { get; set; }
    }
}
