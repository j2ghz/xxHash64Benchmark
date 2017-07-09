``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10.0.16232
Processor=Intel Core i7-4710HQ CPU 2.50GHz (Haswell), ProcessorCount=8
Frequency=2435765 Hz, Resolution=410.5486 ns, Timer=TSC
dotnet cli version=2.0.0-preview2-006497
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJIT
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 |   Method | dataSizeBytes |             Mean |         Error |        StdDev |
 |--------- |-------------- |-----------------:|--------------:|--------------:|
 | **xxHash64** |          **1073** |         **2.215 us** |     **0.0078 us** |     **0.0073 us** |
 | **xxHash64** |         **10737** |        **19.021 us** |     **0.0625 us** |     **0.0585 us** |
 | **xxHash64** |        **107374** |       **186.177 us** |     **0.7968 us** |     **0.7453 us** |
 | **xxHash64** |       **1073741** |     **1,849.961 us** |     **7.2826 us** |     **6.8121 us** |
 | **xxHash64** |      **10737418** |    **18,621.881 us** |    **62.7286 us** |    **58.6764 us** |
 | **xxHash64** |     **107374182** |   **186,785.877 us** |   **614.1825 us** |   **574.5067 us** |
 | **xxHash64** |    **1073741824** | **1,859,136.249 us** | **1,594.9764 us** | **1,331.8774 us** |
