using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Data.HashFunction;

namespace xxHash64Bench
{
    public class HashBench
    {
        [Params(1024, 1024*1024, 1024*1024*1024)]
        public int N { get; set; }

        private byte[] data;

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly xxHash xxH32 = new xxHash(32);
        private readonly xxHash xxH64 = new xxHash(64);

        [GlobalSetup]
        public void GlobalSetup()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        [Benchmark(Baseline = true)]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public byte[] xxHash32() => xxH32.ComputeHash(data).Hash;

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