using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;
enum DateFormat
{
    DateAndTime,
    DateOnly,
    TimeOnly,
    LongMonthDate
}
static class ShowDate
{
    static public string GetDate(DateFormat format)
    {
        var now = DateTime.Now;
        switch (format)
        {
            case DateFormat.DateAndTime:
                return now.ToString();
            case DateFormat.DateOnly:
                return now.ToString("dd/MM/yyyy");
            case DateFormat.TimeOnly:
                return now.ToString("HH");
            case DateFormat.LongMonthDate:
                return now.ToString("MMMM dd, yyyy");
        }
        return "";
    }
}