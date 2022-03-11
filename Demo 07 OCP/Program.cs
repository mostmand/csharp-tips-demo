namespace Demo_07_OCP;

internal static class Program
{
    public static void Main()
    {
        var shapePrinter = new SimpleShapePrinter();
        shapePrinter.Print("CIRCLE");
    }
}