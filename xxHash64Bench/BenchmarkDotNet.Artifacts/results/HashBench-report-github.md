``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10.0.16232
Processor=Intel Core i7-4710HQ CPU 2.50GHz (Haswell), ProcessorCount=8
Frequency=2435765 Hz, Resolution=410.5486 ns, Timer=TSC
dotnet cli version=2.0.0-preview2-006497
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 | Method |     Mean |     Error |    StdDev |
 |------- |---------:|----------:|----------:|
 | Sha256 | 5.721 us | 0.0302 us | 0.0267 us |
 |    Md5 | 2.500 us | 0.0102 us | 0.0095 us |
 |    xxH | 2.194 us | 0.0156 us | 0.0145 us |
