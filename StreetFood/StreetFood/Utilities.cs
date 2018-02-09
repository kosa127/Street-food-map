using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Utilities
    {
        public static int getTodaysTimestamp()
        {
            return (int)new DateTimeOffset(new DateTime(2018, 2, 9, 20, 0, 0, 0, DateTimeKind.Utc))
                .ToUnixTimeSeconds();
        }
    }
}
