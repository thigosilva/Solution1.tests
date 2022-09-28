using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Extensions
{
    public static class DatetimeExtensions
    {
        public static string ToStingShortPtBR(this DateTime data) 
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static string ToStringPtBR(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
