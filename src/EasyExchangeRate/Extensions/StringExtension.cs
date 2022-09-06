using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Extensions
{
    public static class StringExtension
    {
        public static bool IsNullOrEmpty(this string val)
        {
            return String.IsNullOrEmpty(val);
        }
    }
}
