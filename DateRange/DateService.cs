using System.Globalization;

namespace DateRange;

public class DateService
{
    public string? GetDates(string[] args)
    {

        while(true)
        {
            if (!Validator.CheckEntryPointLength(args))
                break;
            
            (string first, string second) datePair = (args[0], args[1]);
            
            if (!Validator.CheckDatesFormat(datePair))
                break;
    
            const string dateFormat = "dd.MM.yyyy";
            var date1 = DateTime.ParseExact(datePair.first, dateFormat, DateTimeFormatInfo.InvariantInfo);
            var date2 = DateTime.ParseExact(datePair.second, dateFormat, DateTimeFormatInfo.InvariantInfo);
            
            var result =  Comparer.GetTimeSpan(date1, date2);

            return result;
        }

        return null;
    }
}