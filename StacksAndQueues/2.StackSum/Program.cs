int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Stack<int> stack  = new Stack<int>(numbers);

string command = "";
while ((command = Console.ReadLine().ToLower()) != "end")
{
    var commandArgs = command.Split();

    if (commandArgs[0] == "add")
    {
        stack.Push(int.Parse(commandArgs[1]));
        stack.Push(int.Parse(commandArgs[2]));
    }
    else
    {
        int count = int.Parse(commandArgs[1]);
        if (count <= stack.Count)
        {
            for (int i  = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");