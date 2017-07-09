using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Data.HashFunction;
using System.Threading.Tasks;

namespace xxHash64Bench
{
    public class HashBench
    {
        [Params(1073, 10737, 107374, 1073741, 10737418, 107374182, 1073741824)]
        public int dataSizeBytes { get; set; }

        private byte[] data;

        private readonly xxHash xxH64 = new xxHash(64);

        [GlobalSetup]
        public void GlobalSetup()
        {
            data = new byte[dataSizeBytes];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public byte[] xxHash64() => xxH64.ComputeHash(data).Hash;
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<HashBench>();
            Console.ReadKey();
        }
    }
}