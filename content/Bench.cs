using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System.Threading;

namespace Bench {

    //[InProcessAttribute]
    public class MyBenchmarks {
        [Benchmark]
        public void ABenchMark() => Thread.Sleep(10);

        public static void Main(string[] args) => BenchmarkRunner
                                                    .Run(typeof(MyBenchmarks).Assembly, DefaultConfig.Instance.With(Job.Default.WithCustomBuildConfiguration("Bench")));
    }
}
