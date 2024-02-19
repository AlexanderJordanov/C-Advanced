int length = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries); 

Predicate<string> predicate = name => name.Length <= length;
foreach (string name in names)
{
    if (predicate(name))
    {
        Console.WriteLine(name);
    }
}