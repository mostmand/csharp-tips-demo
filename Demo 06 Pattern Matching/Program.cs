namespace Demo_06_Pattern_Matching;

internal static class Program
{
    public static void Main()
    {
        var foo = new Foo
        {
            A = 10,
            B = 20,
            Bar = new Bar
            {
                C = 1000
            }
        };

        if (foo is { A: >= 10 })
        {
            Console.WriteLine("A is more than 10");
        }

        if (foo is { A: 10, B: < 30 })
        {
            Console.WriteLine("A equals 10 and B is less than 30");
        }

        if (foo is { A: 10, Bar: { C: 1000 } })
        {
            Console.WriteLine("Wow!!! Beautiful pattern matching");
        }
        
        if (foo is { A: 10, Bar.C: 1000 })
        {
            Console.WriteLine("Awesome!!! Beautiful nested pattern matching");
        }
    }
}