using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFood
{
    class Vendor
    {
        public string descriptionShort { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public string region { get; set; }
        public string url { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public List<PaymentMethod> paymentMethods { get; set; }
        public List<Open> opens { get; set; }

        public Open openToday()
        {
            foreach (Open open in this.opens)
            {
                if (open.isOpennedToday())
                {
                    return open;
                }
            }

            return null;
        }
    }
}
