int[] NSX = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Stack<int> stack = new Stack<int>();
for (int i = 0; i < inputNumbers.Length; i++)
{
    stack.Push(inputNumbers[i]);
}
if (stack.Count >= NSX[1])
{
    for (int i = 0; i < NSX[1]; i++)
    {
        stack.Pop();
    }
}

if (stack.Contains(NSX[2]))
{
    Console.WriteLine("true");
}
else if (stack.Any())
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine(0);
}