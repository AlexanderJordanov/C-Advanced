Queue<string> kids = new Queue<string> (Console.ReadLine()
    .Split()
    .ToArray());
int throws = int.Parse(Console.ReadLine());
int currentThrows = 1;
while (kids.Count > 1)
{
    string currentKid = kids.Dequeue();
    if (currentThrows < throws)
    {
        kids.Enqueue(currentKid);
        currentThrows++;
    }
    else
    {
        currentThrows = 1;
        Console.WriteLine($"Removed {currentKid}");
    }
}
Console.WriteLine($"Last is {kids.Dequeue()}");