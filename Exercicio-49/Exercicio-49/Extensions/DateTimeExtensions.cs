using System.Globalization;
namespace System
{
    static class DateTimeExtensions 
    {
        public static string ElapsedTime(this DateTime obj)
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.CurrentCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.CurrentCulture);
            }
        }
    }
}