using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Exceptions
{
    public class LoadSourceException : Exception
    {
        public LoadSourceException() : base($"Source url is corrupt. Failed to load data from source")
        {

        }
    }
}
