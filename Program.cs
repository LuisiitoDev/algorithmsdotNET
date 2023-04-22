// See https://aka.ms/new-console-template for more information
using algorithmsdotNET;
using BenchmarkDotNet.Running;

//Console.WriteLine(MemoryBenchmarkerDemo.LinealComplex());
//Console.WriteLine(MemoryBenchmarkerDemo.LinealComplex2());
//Console.WriteLine(MemoryBenchmarkerDemo.BinarySearch(10));
//Console.ReadKey();

BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
