namespace DateRange;

public class DateService
{
    public static string? GetDates(string[] args)
    {
        while(true)
        {
            if (!Validator.CheckEntryPointLength(args))
                break;
            
            (string first, string second) datePair = (args[0], args[1]);
            
            if (!Validator.CheckDatesFormat(datePair))
                break;
    
            var date1 = DateTime.ParseExact(datePair.first, globalFormat, DateTimeFormatInfo.InvariantInfo);
            var date2 = DateTime.ParseExact(datePair.second, globalFormat, DateTimeFormatInfo.InvariantInfo);
            
            var result =  Comparer.GetTimeSpan(date1, date2);

            return result;
        }

        return null;
    }
}