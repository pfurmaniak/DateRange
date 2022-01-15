using System.Globalization;

namespace DateRange;

public static class DateService
{
    public static DateTime BuildDate(string date)
    {
        const string dateFormat = "dd.MM.yyyy";
        return DateTime.ParseExact(date, dateFormat, DateTimeFormatInfo.InvariantInfo);
    }
}