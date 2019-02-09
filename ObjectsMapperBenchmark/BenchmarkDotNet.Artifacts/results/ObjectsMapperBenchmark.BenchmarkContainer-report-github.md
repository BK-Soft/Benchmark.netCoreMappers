``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17763.292 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.103
  [Host]     : .NET Core 2.2.1 (CoreCLR 4.6.27207.03, CoreFX 4.6.27207.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.1 (CoreCLR 4.6.27207.03, CoreFX 4.6.27207.03), 64bit RyuJIT


```
|            Method |       Mean |    Error |    StdDev |
|------------------ |-----------:|---------:|----------:|
| MapWithTinyMapper | 5,201.5 ns | 52.29 ns |  48.92 ns |
| MapWithAutoMapper | 2,347.1 ns | 52.44 ns | 151.30 ns |
|    MapWithMapster |   654.2 ns | 23.55 ns |  67.95 ns |
