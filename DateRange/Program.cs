namespace DateRange;

static class Program
{
    // static void Main(string[] args)
    private static void Main()
    {
        string[] args = {"04.01.2017", "05.01.2017"};
        while(true)
        {
            if (!Validator.CheckEntryPointLength(args))
                break;
            
            (string first, string second) datePair = (args[0], args[1]);

            if (!Validator.CheckDatesFormat(datePair))
                break;

            var date1 = DateService.BuildDate(datePair.first);
            var date2 = DateService.BuildDate(datePair.second);
            
            Comparer.GetTimeSpan(date1, date2);
            break;
        }
    }
}