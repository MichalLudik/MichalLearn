``` ini

BenchmarkDotNet=v0.10.5, OS=Windows 6.3.9600
Processor=Intel Core i7-4790 CPU 3.60GHz (Haswell), ProcessorCount=6
Frequency=10000000 Hz, Resolution=100.0000 ns, Timer=UNKNOWN
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1590.0DEBUG [AttachedDebugger]
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1590.0


```
 | Method |      Mean |     Error |    StdDev |
 |------- |----------:|----------:|----------:|
 | Sha256 | 107.94 us | 2.1170 us | 1.9803 us |
 |    Md5 |  21.40 us | 0.2980 us | 0.2787 us |
