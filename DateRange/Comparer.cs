namespace DateRange;

public static class Comparer
{
    private static bool _isMonthDiff;
    private static bool _isYearDiff;
    private static DateTime _firstDate;
    private static DateTime _secondDate;

    public static string? GetTimeSpan(DateTime date1, DateTime date2)
    {
        _firstDate = date1;
        _secondDate = date2;
        
        // no day difference check performed - at this point it
        // was already ensured that the second date is bigger
        _isMonthDiff = date2.Month - date1.Month != 0;
        _isYearDiff = date2.Year - date1.Year != 0;

        var result = TimeSpan();
        
        return result;
    }

    private static string? TimeSpan()
    {
        var timeSpanString = String.Empty;
        
        if (_isYearDiff)
        {
            timeSpanString += $"{_firstDate:dd.MM.yyyy} - {_secondDate:dd.MM.yyyy}";
        }
        else if (_isMonthDiff && !_isYearDiff )
        {
            timeSpanString += $"{_firstDate:dd.MM} - {_secondDate:dd.MM.yyyy}";
        }
        else
        {
            timeSpanString += $"{_firstDate.Day:00} - {_secondDate:dd.MM.yyyy}";
        }

        return timeSpanString;
    }
}