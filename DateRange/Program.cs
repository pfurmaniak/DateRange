namespace DateRange;

class Program
{
    static void Main()
    // static void Main(string[] args)
    {
        string[] args = {"04.01.2017", "05.01.2017"};

        var dateService = new DateService();
        var result = dateService.GetDates(args);
        
        
        Console.WriteLine(result);
    }
}