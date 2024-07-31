using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Globalization;

namespace IjsOpReis.Extentions;

public static class DateTimeExtentions
{
    public static string ToNlString(this DateTime dateTime)
    {
        return dateTime.ToString(new CultureInfo("nl-NL"));
    }

    public static DateTime GetCurrentNlTime()
    {
        DateTime utcNow = DateTime.UtcNow;
        TimeZoneInfo netherlandsTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
        DateTime netherlandsTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, netherlandsTimeZone);

        return netherlandsTime;
    }
}
