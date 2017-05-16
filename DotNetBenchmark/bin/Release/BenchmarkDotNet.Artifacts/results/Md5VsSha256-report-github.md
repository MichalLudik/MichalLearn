``` ini

BenchmarkDotNet=v0.10.5, OS=Windows 6.3.9600
Processor=Intel Core i7-4790 CPU 3.60GHz (Haswell), ProcessorCount=6
Frequency=10000000 Hz, Resolution=100.0000 ns, Timer=UNKNOWN
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1590.0 [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1590.0


```
 |      Method |     Mean |    Error |   StdDev |      Min |      Max |     Gen 0 | Allocated |
 |------------ |---------:|---------:|---------:|---------:|---------:|----------:|----------:|
 | GenerujList | 121.8 ms | 2.309 ms | 2.047 ms | 118.9 ms | 126.2 ms | 5495.8333 |  26.01 MB |
