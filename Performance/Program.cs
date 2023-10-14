// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Performance;

var useField = false;
var iterations = 1000000;

if (args.Length > 0)
{
    if (args[0] == "f")
        useField = true;

    if (!int.TryParse(args[1], out iterations))
        iterations = 1000000;
}

IIterator iterator;

if (useField)
    iterator = new Field(new SomeService());
else
    iterator = new Property(new SomeService());

iterator.SomeMethodUsingService();

Console.WriteLine($"Using: '{iterator.Name}'");
Console.WriteLine($"Iterations: {iterations}");

var watch = new Stopwatch();
watch.Start();

iterator.Iterate(iterations);

watch.Stop();
var ms = watch.ElapsedMilliseconds;

Console.WriteLine($"Time Elapsed: {ms} milliseconds");

Console.ReadLine();