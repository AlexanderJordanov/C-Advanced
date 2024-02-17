using System.Text;

int numberOfOperations = int.Parse(Console.ReadLine());

var builder = new StringBuilder();
var stack  = new Stack<string>();
stack.Push(builder.ToString());

for (int i = 0; i < numberOfOperations; i++)
{
    string[] commandArgs = Console.ReadLine()
        .Split()
        .ToArray();

    if (commandArgs[0] == "1")
    {
        builder.Append(commandArgs[1]);
        stack.Push(builder.ToString());
    }
    else if (commandArgs[0] == "2")
    {
        int count = int.Parse(commandArgs[1]);
        builder.Remove(builder.Length - count, count);
        stack.Push(builder.ToString());
    }
    else if (commandArgs[0] == "3")
    {
        int index = int.Parse(commandArgs[1]);
        Console.WriteLine(builder[index-1]);
    }
    else if (commandArgs[0] == "4")
    {
        stack.Pop();
        builder = new StringBuilder();
        builder.Append(stack.Peek());
    }
}