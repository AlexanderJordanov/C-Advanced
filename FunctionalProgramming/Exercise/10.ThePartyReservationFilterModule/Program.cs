List<string> names = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToList();

List<string> filters = new();
string input = default;

while ((input = Console.ReadLine()) != "Print")
{
    string[] commandArgs = input.Split(';');
    string command = commandArgs[0];
    string filterType = commandArgs[1];
    string filterParameter = commandArgs[2];

    if (command == "Add filter")
    {
        filters.Add(filterType + " " + filterParameter);
    }
    else if (command == "Remove filter")
    {
        filters.Remove(filterType + " " + filterParameter);
    }
}    

foreach(string filter in filters)
{
    string[] commandArgs = filter.Split(' ');
    
    string filterType = commandArgs[0];
    

    if (filterType == "Starts")
    {
        string filterParameter = commandArgs[2];
        names = names.Where(name => !name.StartsWith(filterParameter)).ToList();
    }
    else if (filterType == "Ends")
    {
        string filterParameter = commandArgs[2];
        names = names.Where(name => !name.EndsWith(filterParameter)).ToList();
    }
    else if (filterType == "Length")
    {
        string filterParameter = commandArgs[1];
        names = names.Where(name => name.Length != int.Parse(filterParameter)).ToList();

    }
    else if (filterType == "Contains")
    {
        string filterParameter = commandArgs[1];
        names = names.Where(name => !name.Contains(filterParameter)).ToList();
    }
}

if (names.Any())
{
    Console.WriteLine(string.Join(" ", names));
}