using System;
using BenchmarkDotNet.Running;

namespace ObjectsMapperBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = BenchmarkRunner.Run<BenchmarkContainer>();
            Console.ReadLine();
            
        }
    }
}
