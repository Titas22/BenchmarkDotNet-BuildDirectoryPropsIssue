using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace SampleBenchmark;

public class BenchmarkClass
{
    [GlobalSetup]
    public void Setup()
    {
       // Setup code here, if needed
    }

    [GlobalCleanup]
    public void Cleanup()
    {
       // Cleanup code here, if needed
    }
    [Benchmark]
    public void Scenario1()
    {
        // Implement your benchmark here
    }

    [Benchmark]
    public void Scenario2()
    {
        // Implement your benchmark here
    }
}
