using App;
using BenchmarkDotNet.Running;
using DEdge;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Cardidy.Identify("4127540509730813").Single());
        var summary = BenchmarkRunner.Run<BenchmarkCardidy>();
    }

    Console.WriteLinesummary}