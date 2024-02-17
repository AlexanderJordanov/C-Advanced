int totalFoodForTheDay = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse) 
    .ToArray();

Queue<int> ordersQueue = new Queue<int>(orders);

Console.WriteLine(ordersQueue.Max());

for (int i = 0; i < ordersQueue.Count; i++)
{
    if (ordersQueue.Peek() <= totalFoodForTheDay)
    {
        totalFoodForTheDay -= ordersQueue.Dequeue();
        i--;
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(" ",ordersQueue)}");
        return;
    }
}
Console.WriteLine("Orders complete");