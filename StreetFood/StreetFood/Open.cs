using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

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
            if (this.start <= Utilities.Utilities.getTodaysTimestamp())
            {
                if (this.end >= Utilities.Utilities.getTodaysTimestamp())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
