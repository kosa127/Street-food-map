using System.Globalization;

namespace StreetFood.models
{
    class PaymentMethod
    {
        public string name { get; set; }

        public string getName()
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.name.ToLower()).Replace("_", " ");
        }
    }
}
