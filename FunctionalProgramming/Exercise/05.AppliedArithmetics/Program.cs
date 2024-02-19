using System.Data;

int[] numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = default;
Func<int, int> func = x => x;
Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

while ((command = Console.ReadLine()) != "end")
{
    if (command == "add")
    {
        func = x => x + 1;
    }
    else if (command == "multiply")
    {
        func = x => x * 2;
    }
    else if (command == "subtract")
    {
        func = x => x - 1;
    }
    else if (command == "print")
    {
        print(numbers);
        continue;
    }
    numbers = numbers.Select(x => func(x)).ToArray();
}

