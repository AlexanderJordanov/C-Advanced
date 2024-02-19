int[] lines = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string filter = Console.ReadLine();
List<int> numbers = new List<int>();
int number = 0;
Predicate<int> predicate = GetPredicate(number, filter);
for (int i = lines[0]; i <= lines[1]; i++)
{
    number = i;
    if (predicate(number))
    {
        numbers.Add(number);
    }
}
Console.WriteLine(string.Join(" ", numbers));


Predicate<int> GetPredicate(int number, string filter)
{
    if (filter == "odd")
    {
        return number => number % 2 != 0;
    }
    else if (filter == "even")
    {
        return number => number % 2 == 0;
    }
    return default;
}