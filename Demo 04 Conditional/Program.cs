using System;
using System.Diagnostics;

namespace Demo_04_Conditional;

internal static class Program
{
    private static bool _debugMode = false;

    public static void Main()
    {
        A();
        B();
        Console.WriteLine(_debugMode);
    }

    private static void A()
    {
#if DEBUG
        _debugMode = true;
#endif
    }

    [Conditional("DEBUG")]
    private static void B()
    {
        _debugMode = true;
    }
}