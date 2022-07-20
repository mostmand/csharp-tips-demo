using System.Text;
using BenchmarkDotNet.Running;
using Demo_12_ArrayPool.Shared;

BenchmarkRunner.Run<Benchmarks>();

// const string filePath = "Resources/content.txt";
// const int bufferSize = 2 * 1024;
//
// async Task<string> ReadToEndAsync(byte[] buffer)
// {
//     await using var fileStream = File.OpenRead(filePath);
//     var result = new StringBuilder();
//     int readBytes;
//     while ((readBytes = await fileStream.ReadAsync(buffer)) > 0)
//     {
//         result.Append(Encoding.UTF8.GetString(buffer[..readBytes]));
//     }
//
//     return result.ToString();
// }
//
// var buffer = new byte[bufferSize];
// var result = await ReadToEndAsync(buffer);
