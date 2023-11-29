using BenchmarkDotNet.Running;
using NutshellConsole;

var summary = BenchmarkRunner.Run<BenchmarkTester>();
Console.Read();