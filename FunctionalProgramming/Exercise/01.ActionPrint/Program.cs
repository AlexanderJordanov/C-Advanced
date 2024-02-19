string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action<string> writer = p => Console.WriteLine(p);

foreach (var name in names)
{
    writer(name);
}