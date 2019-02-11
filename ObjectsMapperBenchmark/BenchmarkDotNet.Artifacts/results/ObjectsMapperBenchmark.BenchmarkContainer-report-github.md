``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.523 (1803/April2018Update/Redstone4)
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=2531249 Hz, Resolution=395.0619 ns, Timer=TSC
.NET Core SDK=2.2.103
  [Host] : .NET Core 2.2.1 (CoreCLR 4.6.27207.03, CoreFX 4.6.27207.03), 64bit RyuJIT

Job=InProcess  Toolchain=InProcessToolchain  

```
|               Method |       Mean |    Error |    StdDev |
|--------------------- |-----------:|---------:|----------:|
|   MapWithAgileMapper | 2,006.0 ns | 47.26 ns | 134.08 ns |
|    MapWithTinyMapper | 5,514.2 ns | 29.57 ns |  27.66 ns |
| MapWithExpressMapper | 4,186.7 ns | 91.35 ns | 105.20 ns |
|    MapWithAutoMapper | 2,223.7 ns | 44.21 ns |  52.63 ns |
| MapWithManualMapping | 1,193.1 ns | 23.75 ns |  52.62 ns |
|       MapWithMapster |   544.8 ns | 11.33 ns |  25.10 ns |
