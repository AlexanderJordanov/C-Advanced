int end = int.Parse(Console.ReadLine());
int[] divisors = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int, bool> predicate = (array, i) =>
{
    bool isDivisble = true;
    {
        foreach (int divisor in divisors)
        {
            if (i % divisor != 0)
            {
                isDivisble = false;
            }
        }
        return isDivisble;
    }
};

List<int> numbers = new List<int>();
for (int i = 1; i <= end; i++)
{
    if (predicate(divisors, i))
    {
        numbers.Add(i);
    }
}

Console.WriteLine(string.Join(" ", numbers));