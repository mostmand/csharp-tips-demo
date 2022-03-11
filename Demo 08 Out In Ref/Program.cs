namespace Demo_08_Out_In_Ref;

internal static class Program
{
    public static void Main()
    {
        var dictionary = new Dictionary<string, string> { { "A", "Salam" } };
        dictionary.TryGetValue("A", out var value);
        Console.WriteLine(value);
    }

    private static void InExample(in char character)
    {
        if (character == 'a')
        {
            Console.WriteLine("It's \"a\"!");
        }
    }

    private static void RefExample(ref char character)
    {
        if (character == 'a')
        {
            Console.WriteLine("It's \"a\"!");
            character = 'z';
        }
    }

    private static void OutExample(out char character)
    {
        character = 'z';
    }
}