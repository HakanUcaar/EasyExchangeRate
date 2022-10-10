using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Extensions
{
    public static class DateExtension
    {
        public static bool IsWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
        public static DateTime FridayOfLastWeek(this DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Friday)
            {
                date = date.AddDays(-1);
            }
            return date;
        }
    }
}
