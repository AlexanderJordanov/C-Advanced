string[] knights = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action<string> promote = k => Console.WriteLine($"Sir {k}");

foreach ( var k in knights)
{
    promote(k);
}
