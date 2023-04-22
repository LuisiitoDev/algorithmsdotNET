using BenchmarkDotNet.Attributes;

namespace algorithmsdotNET;

[MemoryDiagnoser]
public class MemoryBenchmarkerDemo
{
    public static int[] Numbers => Enumerable.Range(0, 100).Select(i => i).ToArray();

    [Benchmark]
    public (decimal sum, decimal multiplication) LinealComplex() => dotNetAlgorithms.LinealComplex(Numbers);

    [Benchmark]
    public decimal LinealComplex2() => dotNetAlgorithms.LineaComplex2(Numbers);

    [Benchmark]
    [Arguments(10)]
    [Arguments(50)]
    [Arguments(30)]
    [Arguments(100)]
    public int BinarySearch(int target) => dotNetAlgorithms.BinarySearch(Numbers, target);
}