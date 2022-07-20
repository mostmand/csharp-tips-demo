using BenchmarkDotNet.Attributes;
using FastEnumUtility;

namespace Demo_13_Enum_Performance;

[MemoryDiagnoser]
public class Benchmarks
{
    private const string ColorToFind = "Aqua";
    
    [Benchmark]
    public Color? EnumParse()
    {
        var parsed = Enum.TryParse<Color>(ColorToFind, out var result);
        if (!parsed)
        {
            return null;
        }
        return result;
    }

    [Benchmark]
    public Color? ColorExtensionsParse()
    {
        var parsed = MyColorExtensions.TryParse(ColorToFind, out var result);
        if (!parsed)
        {
            return null;
        }
        return result;
    }

    [Benchmark]
    public Color? FastEnumParse()
    {
        var parsed = FastEnum.TryParse<Color>(ColorToFind, out var result);
        if (!parsed)
        {
            return null;
        }
        return result;
    }

    [Benchmark]
    public Color? EnumGeneratorsParse()
    {
        var parsed = ColorExtensions.TryParse(ColorToFind, out var result);
        if (!parsed)
        {
            return null;
        }
        return result;
    }
}