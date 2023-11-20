namespace ODataDemo.Helpers.Extensions
{
    public static class AnyTimeZoneExtension
    {
        public static DateTime ToSpecificTimeZone(this DateTime utcDateTime, int hoursOffset, int minutesOffset = 0)
        {
            TimeSpan timeOffset = new TimeSpan(hoursOffset, minutesOffset, 0);
            DateTime targetTime = utcDateTime + timeOffset;
            return targetTime;
        }
    }
}
