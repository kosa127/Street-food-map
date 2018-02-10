namespace StreetFood.models
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
            if (this.start <= Utilities.getTodaysTimestamp())
            {
                if (this.end >= Utilities.getTodaysTimestamp())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
