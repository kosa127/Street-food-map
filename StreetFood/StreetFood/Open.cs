using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFood
{
    class Open
    {
        public int start { get; set; }
        public int end { get; set; }
        public string display { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }

        public bool isOpennedToday()
        {
            if (this.start <= this.getTodaysTimestamp())
            {
                if (this.end >= this.getTodaysTimestamp())
                {
                    return true;
                }
            }

            return false;
            //return ((this.start <= this.getTodaysTimestamp()) && (this.end >= this.getTodaysTimestamp()));
        }

        private int getTodaysTimestamp()
        {
            return (int)new DateTimeOffset(new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc))
                .ToUnixTimeSeconds();
        }
    }
}
