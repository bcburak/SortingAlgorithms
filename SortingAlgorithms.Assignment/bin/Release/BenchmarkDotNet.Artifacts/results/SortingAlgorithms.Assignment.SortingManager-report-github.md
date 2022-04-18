``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19041.685 (2004/May2020Update/20H1)
Intel Core i7-8665U CPU 1.90GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
  [Host] : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT


```
|        Method |       arr | Mean | Error | Rank |
|-------------- |---------- |-----:|------:|-----:|
| InsertionSort | Object[2] |   NA |    NA |    ? |

Benchmarks with issues:
  SortingManager.InsertionSort: DefaultJob [arr=Object[2]]
