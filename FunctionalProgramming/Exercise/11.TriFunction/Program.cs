int minSum = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();
Func<string, bool> predicate = name => name.Sum(c => c) >= minSum;
foreach (string name in names)
{
    if (predicate(name))
    {
        Console.WriteLine(name);
        break;
    }
}