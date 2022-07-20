using System.Text;
using BenchmarkDotNet.Attributes;

namespace Demo_10_StringBuilder;

[MemoryDiagnoser()]
public class Benchmarks
{
    private static readonly IEnumerable<string> strings = new[]
    {
        "Mohammad",
        "Ahmad",
        "Sadegh",
        "Ali",
        "Reza",
        "Zahra",
        "Nima"
    };

    [Benchmark]
    public string StringAppend()
    {
        var result = "";
        foreach (var s in strings)
        {
            result += s;
        }

        return result;
    }

    [Benchmark]
    public string StringBuilder()
    {
        var stringBuilder = new StringBuilder();
        foreach (var s in strings)
        {
            stringBuilder.Append(s);
        }

        return stringBuilder.ToString();
    }

    [Benchmark]
    public string StringJoin()
    {
        return string.Join("", strings);
    }
}