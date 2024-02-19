Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
int matches = 0;
int wormsCount = worms.Count;
while (holes.Count > 0 && worms.Count > 0)
{
    int worm = worms.Pop();
    int hole = holes.Dequeue();
    if (worm == hole)
    {
        matches++;
        continue;
    }
    else
    {
        worm -= 3;
        if (worm <= 0)
        {
            continue;
        }
        else
        {
            worms.Push(worm);
        }
    }
}
if (matches == 0)
{
    Console.WriteLine($"There are no matches.");
}
else
{
    Console.WriteLine($"Matches: {matches}");
}

if (worms.Count == 0 && matches == wormsCount)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (worms.Count == 0)
{
    Console.WriteLine($"Worms left: none");
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}

if (holes.Count == 0)
{
    Console.WriteLine($"Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}