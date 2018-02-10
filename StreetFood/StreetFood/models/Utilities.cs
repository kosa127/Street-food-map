using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFood
{
    class Utilities
    {
        public static int getTodaysTimestamp()
        {
            return (int)new DateTimeOffset(new DateTime(2018, 2, 10, 20, 0, 0, 0, DateTimeKind.Utc))
                .ToUnixTimeSeconds();
        }

        public static string getTime(int timestamp)
        {
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(timestamp).ToLocalTime();

            return dt.ToString("HH:mm");
        }
    }
}
