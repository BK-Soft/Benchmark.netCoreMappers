``` ini

BenchmarkDotNet=v0.10.10, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.19)
Processor=Intel Core i7-6500U CPU 2.50GHz (Skylake), ProcessorCount=4
Frequency=2531250 Hz, Resolution=395.0617 ns, Timer=TSC
.NET Core SDK=2.1.1-preview-007094
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
|            Method |       Mean |     Error |    StdDev |     Median |
|------------------ |-----------:|----------:|----------:|-----------:|
| MapWithTinyMapper | 6,650.0 ns | 144.03 ns | 408.59 ns | 6,521.9 ns |
| MapWithAutoMapper | 2,102.1 ns |  55.99 ns | 162.43 ns | 2,027.7 ns |
|    MapWithMapster |   651.7 ns |  24.38 ns |  68.36 ns |   635.5 ns |
