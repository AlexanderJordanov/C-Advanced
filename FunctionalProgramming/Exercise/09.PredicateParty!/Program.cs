List<string> names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = default;

while ((input = Console.ReadLine()) != "Party!")
{
    string[] command = input.Split();
    Func<string, bool> predicate = GetPredicate(command[1], command[2]);

    if (command[0] == "Remove")
    {
        names = Remove(names, predicate);
    }
    else if (command[0] == "Double")
    {
        names = Double(names, predicate);
    }
}

Console.WriteLine(names.Any() ?
    $"{string.Join(", ", names)} are going to the party!" :
    "Nobody is going to the party!");

Func<string, bool> GetPredicate(string command, string criteria)
{
    if (command == "StartsWith")
    {
        return s => s.StartsWith(criteria);
    }
    else if (command == "EndsWith")
    {
        return s => s.EndsWith(criteria);
    }
    else if (command == "Length")
    {
        return s => s.Length == int.Parse(criteria);
    }

    return default;
}

static List<string> Double (List<string> names, Func<string, bool> predicate)
{
    List<string> result = new List<string>();
    foreach (string name in names)
    {
        if (predicate(name))
        {
            result.Add(name);
        }
        result.Add(name);
    }
    return result;
}

static List<string> Remove (List<string> names, Func<string, bool> predicate)
{
    return names.Where(name => predicate(name) == false).ToList();
}