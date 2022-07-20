namespace Demo_13_Enum_Performance;

public static class MyColorExtensions
{
    private static readonly IReadOnlyDictionary<string, Color> EnumByString = CreateEnumByString();

    private static IReadOnlyDictionary<string, Color> CreateEnumByString()
    {
        return Enum.GetValues<Color>()
            .ToDictionary(x => x.ToString());
    }

    public static bool TryParse(string colorToParse, out Color color)
    {
        return EnumByString.TryGetValue(colorToParse, out color);
    }
}