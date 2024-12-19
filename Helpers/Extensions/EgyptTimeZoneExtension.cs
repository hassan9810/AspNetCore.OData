namespace ODataDemo.Helpers.Extensions
{
    public static class EgyptTimeZoneExtension
    {
        public static DateTime ToEgyptTimeZone(this DateTime utcDateTime)
        {
            TimeSpan cairoOffset = TimeSpan.FromHours(2);

            DateTime cairoTime = utcDateTime + cairoOffset;
            return cairoTime;
        }
    }
}