namespace DateRange;
static class Program
{
    static void Main(string[] args)
    {
        var result = DateService.GetDates(args);
        WriteLine(result);
    }
}