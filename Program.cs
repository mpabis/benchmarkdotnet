// https://github.com/dotnet/BenchmarkDotNet

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(Program).Assembly);

[MemoryDiagnoser]
public class BenchmarkTest
{
    [GlobalSetup]
    public void GlobalSetup()
    {
        //Write your initialization code here
    }

    [Benchmark]
    public void Test1()
    {
        var now = DateTime.UtcNow;
        var later = now.AddHours(1);
    }
}