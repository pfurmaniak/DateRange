namespace DateRange;

public static class Comparer
{
    private static bool _isDayDiff;
    private static bool _isMonthDiff;
    private static bool _isYearDiff;
    private static DateTime _firstDate;
    private static DateTime _secondDate;

    public static void GetTimeSpan(DateTime date1, DateTime date2)
    {
        _firstDate = date1;
        _secondDate = date2;
        
        _isDayDiff = date2.Day - date1.Day != 0;
        _isMonthDiff = date2.Month - date1.Month != 0;
        _isYearDiff = date2.Year - date1.Year != 0;

        PrintTimeSpan();
    }

    private static void PrintTimeSpan()
    {
        if (_isYearDiff)
        {
            var timeSpanString = _firstDate.ToString("dd.MM.yyyy") + " - " +
                                 _secondDate.ToString("dd.MM.yyyy");
            Console.WriteLine(timeSpanString);
        }
        else if (_isMonthDiff && !_isYearDiff )
        {
            var timeSpanString = _firstDate.ToString("dd.MM") + " - " +
                             _secondDate.ToString("dd.MM.yyyy");
            Console.WriteLine(timeSpanString);
                
        }
        else
        {
            var timeSpanString = _firstDate.Day.ToString("00") + " - " + _secondDate.ToString("dd.MM.yyyy");
            Console.WriteLine(timeSpanString);
        }
    }
}
