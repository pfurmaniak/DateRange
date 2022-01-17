namespace DateRange;
static class Program
{
    static void Main(string[] args)
    {
        try
        {
            var dateService = new DateService();
            var result = dateService.GetDates(args);
            WriteLine(result);
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}