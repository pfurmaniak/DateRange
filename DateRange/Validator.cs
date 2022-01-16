namespace DateRange;

public static class Validator
{
    public static bool CheckEntryPointLength(string[] args)
    {
        if (args.Length == 2)
            return true;
        
        PrintInvalidMessage("wrongLength");
        return false;
    }

    public static bool CheckDatesFormat((string,string)dateStringPair)
    {
        return TryParse(dateStringPair) && CheckIfInputEmpty(dateStringPair) && IsSecondBigger(dateStringPair);
    }

    private static bool CheckIfInputEmpty((string,string)dateStringPair)
    {
        if (dateStringPair.Item1.Length != 0 || dateStringPair.Item2.Length != 0)
            return true;
        
        PrintInvalidMessage("isEmpty");
        return false;
    }

    private static bool TryParse((string,string)dateStringPair )
    {
        string[] dateFormats = {globalFormat};

        var parseSucceded = DateTime.TryParseExact(dateStringPair.Item1, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out _)
                            && DateTime.TryParseExact(dateStringPair.Item2, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out _);
        if (parseSucceded)
            return true;
        
        PrintInvalidMessage("wrongFormat");
        return false;
    }

    private static bool IsSecondBigger((string, string) dateStringPair)
    {
        var date1 = DateTime.Parse(dateStringPair.Item1);
        var date2 = DateTime.Parse(dateStringPair.Item2);
        var difference = DateTime.Compare(date1, date2);

        if (difference < 0)
            return true;

        PrintInvalidMessage("secondNotBigger");
        return false;
    }
    
    private static void PrintInvalidMessage(string error)
    {
        switch(error)
        {
            case "isEmpty":
                WriteLine("Error: No input provided.\nTry again.");
                break;
            case "wrongFormat":
                WriteLine("Error: Wrong date format provided - please use the dd-mm-yyyy format.\nTry again.");
                break;
            case "wrongLength":
                WriteLine("Error: Wrond input - please provide 2 seperate dates in dd-mm-yyyy format.\nTry again.");
                break;
            case "secondNotBigger":
                WriteLine("Error: Second date must be bigger.\nTry again.");
                break;
        }
    }
}