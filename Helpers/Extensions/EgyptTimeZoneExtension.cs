namespace ODataDemo.Helpers.Extensions
{
    public static class EgyptTimeZoneExtension
    {
        public static DateTime ToEgyptTimeZone(this DateTime utcDateTime)
        {
            TimeSpan saudiOffset = TimeSpan.FromHours(2);

            DateTime saudiArabiaTime = utcDateTime + saudiOffset;
            return saudiArabiaTime;
        }
    }
}
