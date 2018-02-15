using System;

namespace StreetFood.models
{
    class Utilities
    {
        private static DateTime currentTime = new DateTime(2018, 2, 15, 20, 0, 0, 0, DateTimeKind.Utc);

        public static int getTodaysTimestamp()
        {
            return (int)new DateTimeOffset(Utilities.currentTime).ToUnixTimeSeconds();
        }

        public static string getTime(int timestamp)
        {
            return Utilities.currentTime.AddSeconds(timestamp).ToLocalTime().ToString("HH:mm");
        }
    }
}
