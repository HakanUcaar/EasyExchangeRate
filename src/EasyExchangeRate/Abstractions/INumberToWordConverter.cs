using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Abstractions
{
    public interface INumberToWordConverter
    {
        string Convert(long number);
    }
}
