using System.Text;

Stack<int> initialFuels = new Stack<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());
Queue<int> additionalFuelConsumptions = new Queue<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
Queue<int> fuelsNeeded = new Queue<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());
int altitide = 0;
bool hasReachedTop = true;
while (fuelsNeeded.Count > 0)
{
    int initialFuel = initialFuels.Pop();
    int fuelConsumption = additionalFuelConsumptions.Dequeue();
    int fuelNeeded = fuelsNeeded.Dequeue();
    if (initialFuel - fuelConsumption >= fuelNeeded)
    {
        altitide++;
        Console.WriteLine($"John has reached: Altitude {altitide}");
    }
    else
    {
        altitide++;
        Console.WriteLine($"John did not reach: Altitude {altitide}");
        hasReachedTop = false;
        break;
    }
}
if (!hasReachedTop)
{
    altitide--;
    Console.WriteLine("John failed to reach the top.");
    if (altitide <= 0)
    {
        Console.WriteLine("John didn't reach any altitude.");
    }
    else 
    {        
        StringBuilder sb = new();
        string outPut = default;
        for (int i = 1; i <= altitide; i++)
        {
            while (i <= altitide - 1) 
            {
                sb.Append($"Altitude {i}, ");
                i++;
            }
            sb.Append($"Altitude {i}");      
            outPut = sb.ToString();
        }
        Console.WriteLine($"Reached altitudes: {outPut}");
    }
}
else
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}