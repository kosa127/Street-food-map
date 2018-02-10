using System;

namespace StreetFood.models
{
    class Utilities
    {
        public static int getTodaysTimestamp()
        {
            return (int)new DateTimeOffset(new DateTime(2018, 2, 12, 20, 0, 0, 0, DateTimeKind.Utc))
                .ToUnixTimeSeconds();
        }
    }
}
