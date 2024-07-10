
using BenchmarkDotNet.Running;
using DotNetSampleApp;
using static System.Console;

var now = DateTime.Now;

if (now > new DateTime(2022, 10, 1))
{
    WriteLine($"DotNetSampleApp is running {now}...");
}

BenchmarkRunner.Run<BenchmarkPerformance>();

WriteLine("Press any key to continue...");

ReadKey();
