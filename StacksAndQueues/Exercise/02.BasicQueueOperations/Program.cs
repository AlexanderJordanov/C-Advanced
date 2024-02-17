int[] NSX = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

if (queue.Count >= NSX[1])
{
    for (int i = 0; i < NSX[1]; i++)
    {
        queue.Dequeue();
    }
}

if (!queue.Any())
{
    Console.WriteLine(0);
}
else if (queue.Contains(NSX[2]))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}