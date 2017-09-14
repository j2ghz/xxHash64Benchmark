using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Data.HashFunction;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
using System.IO;

namespace xxHash64Bench
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<HashBench>();
            Console.ReadKey();
        }
    }

    public class HashBench
    {
        private const string path = @"D:\hashed2\1D-E9-39-0D-F2-FD-6D-F4";
        private readonly xxHash xxH64 = new xxHash(64);

        [Benchmark]
        public async Task<byte[]> FileIO()
        {
            using (var stream = new FileInfo(path).Open(FileMode.Open))
            {
                return await this.xxH64.ComputeHashAsync(stream);
            }
        }

        [Benchmark]
        public async Task<byte[]> Mmf()
        {
            using (var file = MemoryMappedFile.CreateFromFile(path))
            using (var stream = file.CreateViewStream())
            {
                return await this.xxH64.ComputeHashAsync(stream);
            }
        }
    }
}