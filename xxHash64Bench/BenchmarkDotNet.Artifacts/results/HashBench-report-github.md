``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-3770 CPU 3.40GHz (Ivy Bridge), ProcessorCount=8
Frequency=3312794 Hz, Resolution=301.8600 ns, Timer=TSC
dotnet cli version=2.0.1-servicing-006933
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 | Method |     Mean |     Error |    StdDev |
 |------- |---------:|----------:|----------:|
 | FileIO | 4.893 ms | 0.0768 ms | 0.0681 ms |
 |    Mmf | 2.999 ms | 0.0598 ms | 0.0857 ms |
