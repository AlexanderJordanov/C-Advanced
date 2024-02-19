Queue<int> tools = new Queue<int> (Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
Stack<int> substances = new Stack<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
List<int> challenges = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
while (challenges.Count > 0)
{
    int tool = tools.Dequeue();
    int substance = substances.Pop();
    int foundChallenge = challenges.FirstOrDefault(c => c == tool * substance);
    if (foundChallenge != 0)
    {
        challenges.Remove(foundChallenge);
    }
    else
    {
        tool += 1;
        tools.Enqueue(tool);
        substance -= 1;
        if (substance > 0)
        {
            substances.Push(substance);
        }
    }
    if ((substances.Count <= 0 || tools.Count <= 0) && challenges.Count > 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }
}
if (challenges.Count <= 0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}
if (tools.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}

if (substances.Count > 0) 
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challenges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}