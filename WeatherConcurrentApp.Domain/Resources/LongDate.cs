using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Resources
{
    public class LongDate
    {
        public DateTime convertLongToDate(long date)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            time = time.AddSeconds(date).ToLocalTime();
            return time;
        }
    }
}
