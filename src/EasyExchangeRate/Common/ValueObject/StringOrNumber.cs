using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common.ValueObject
{
    public class StringOrNumber : OneOfBase<string, long>
    {
        StringOrNumber(OneOf<string, long> _) : base(_) { }

        public static implicit operator StringOrNumber(string _) => new StringOrNumber(_);
        public static implicit operator StringOrNumber(long _) => new StringOrNumber(_);

        public (bool IsNumber, long Number) TryGetNumber() =>
            Match(
                s => (long.TryParse(s, out var n), n),
                i => (true, i)
            );

        public (bool IsString, string Text) GetString() =>
            Match(
                s => (true, s),
                i => (false, i.ToString() )
            );
    }
}
