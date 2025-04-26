using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace SampleBenchmark;

public class Program
{
    public static void Main(string[] args)
    {
        IConfig config = DefaultConfig.Instance;
        BenchmarkDotNet.Reports.Summary summary = BenchmarkRunner.Run<BenchmarkClass>(config, args);

        // Use this to select benchmarks from the console:
        // var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);

        Console.ReadLine();
    }
}
