using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Exceptions
{
    public class NullException : Exception
    {
        public NullException(string name) : base($"{name} is not null")
        {

        }
    }
}
