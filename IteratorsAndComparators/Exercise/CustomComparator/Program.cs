int[] array = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int, int, int> delegate1 = (x, y) =>
{
    if (x % 2 == 0 && y % 2 != 0)
    {
        return -1;
    }
    if (x % 2 != 0 && y % 2 == 0)
    {
        return 1;
    }

    return x.CompareTo(y);
};

Array.Sort(array, (x, y) => delegate1(x, y));

Console.WriteLine(string.Join(' ', array));