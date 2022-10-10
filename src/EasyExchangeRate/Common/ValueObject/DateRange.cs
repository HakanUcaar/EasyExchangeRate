using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EasyExchangeRate.Common.ValueObject
{
    public class DateRange : EasyValueOf<(DateTime startDate, DateTime endDate), DateRange>
    {
        public DateTime StartDate => Value.startDate;
        public DateTime EndDate => Value.endDate;
        protected override void Validate()
        {
            if (StartDate.Date > EndDate.Date)
                throw new ArgumentException("StartDate cannot be greater than EndDate");

            if (EndDate.Date > DateTime.Now.Date)
                throw new ArgumentException("EndDate cannot be greater than Now");
        }

        public int Days()
        {
            return (EndDate - StartDate).Days;
        }
        public List<DateTime> ToDateList()
        {
            var days = new List<DateTime>();
            var firstDate = StartDate;

            do
            {
                days.Add(firstDate);
                firstDate = firstDate.AddDays(1);
            } while (firstDate.Date != EndDate.Date.AddDays(1));

            return days;
        }
    }
}
