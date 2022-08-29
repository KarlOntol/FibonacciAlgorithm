using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using cs06;

namespace Benchmark;

[MemoryDiagnoser]
public class FibBenchmark
{
    private const int _num = 20;

    [Benchmark(Description = "One recursion call, previous value passed")]
    public uint Fib1()
    {
        uint count = 0;
        return Fibonacci.Fib1(_num, ref count);
    }

    [Benchmark(Description = "Two recursion calls")]
    public uint Fib2()
    {
        uint count = 0;
        return Fibonacci.Fib2(_num, ref count);
    }

    [Benchmark(Description = "Array based solution")]
    public uint Fib3()
    {
        uint count = 0;
        return Fibonacci.Fib3(_num, ref count);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
    }
}