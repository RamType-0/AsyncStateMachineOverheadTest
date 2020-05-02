using System;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Jobs;
namespace AsyncStateMachineOverheadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<NestedAsync>();
        }
    }
    [MonoJob("Mono 6.8.0", @"C:\Program Files\Mono\bin\mono.exe")]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public partial class NestedAsync
    {
        [Benchmark]
        public async ValueTask NestedNoAsync()
        {
            await NestedNoAsync20();
        }
        [Benchmark]
        public async ValueTask InlineNoAsync()
        {

        }

        [Benchmark]
        public async ValueTask NestedYieldOnce()
        {
            await NestedYieldOnce20();
        }

        [Benchmark]
        public async ValueTask InlineYieldOnce()
        {
            await Task.Yield();
        }

        [Benchmark]
        public async ValueTask NestedYieldEach()
        {
            await NestedYieldEach20();
        }

        
        [Benchmark]
        public async ValueTask InlineYieldEach()
        {
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();

            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();

            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();

            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
            await Task.Yield();
        }

        public async ValueTask NestedNoAsync1()
        {

        }
        public async ValueTask NestedYieldOnce1()
        {
            await Task.Yield();
        }
        public async ValueTask NestedYieldEach1()
        {
            await Task.Yield();
        }




    }

}
