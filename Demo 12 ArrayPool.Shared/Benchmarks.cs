using System.Buffers;
using BenchmarkDotNet.Attributes;

namespace Demo_12_ArrayPool.Shared;

[MemoryDiagnoser]
public class Benchmarks
{
    private const int BufferSize = 2 * 1024;
    
    [Benchmark]
    public int CreateArray()
    {
        var sizeSum = 0;
        for (int i = 0; i < 100; i++)
        {
            var bytes = new byte[BufferSize];
            sizeSum += bytes.Length;
        }

        return sizeSum;
    }

    [Benchmark]
    public int ArrayPool()
    {
        var sizeSum = 0;
        for (int i = 0; i < 100; i++)
        {
            var bytes = ArrayPool<byte>.Shared.Rent(BufferSize);
            sizeSum += bytes.Length;
            ArrayPool<byte>.Shared.Return(bytes);
        }

        return sizeSum;
    }
    
    
}