namespace Demo_05_DateOnly;

internal static class Program
{
    public static void Main()
    {
        var dateOnly = DateOnly.FromDateTime(DateTime.Now.Date);
        Console.WriteLine(dateOnly);
    }
}