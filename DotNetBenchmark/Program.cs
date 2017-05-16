using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;

namespace DotNetBenchmark
{
    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<Md5VsSha256>();
            Console.ReadLine();
        }
    }

    [MarkdownExporter,MinColumn, MaxColumn, MemoryDiagnoser,RPlotExporter,Config(typeof(Config))]
    public class Md5VsSha256
    {
        public class Config : ManualConfig
        {
            public Config()
            {
                Add(CsvMeasurementsExporter.Default);
                Add(RPlotExporter.Default);
            }
        }

        private const int N = 10000;
        private readonly byte[] data;
        private List<int> zoznam = new List<int>();

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly MD5 md5 = MD5.Create();

        public Md5VsSha256()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        //[Benchmark]
        //public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public int GenerujList()
        {
            for (int i = 0; i < 100000; i++)
            {
                zoznam.Add(new Random(1000).Next(100000));
            }
            return zoznam.Count;
        }

        //[Benchmark]
        //public byte[] Md5() => md5.ComputeHash(data);

        //[Benchmark]
        //public byte[] ABC() => sha256.ComputeHash(data);
    }
}
