using System;

namespace Demo_01_Records;

internal static class Program
{
    public static void Main()
    {
        var foo = new Foo("Salam", 23);
        var bar = new Foo("Salam", 23);
        
        Console.WriteLine(foo == bar);
    }
}