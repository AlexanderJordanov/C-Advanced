int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int divider = int.Parse(Console.ReadLine());
Predicate<int> predicate = x => x % divider != 0;
Console.WriteLine(string.Join(" ", numbers.Where(x => predicate(x)).Reverse()));