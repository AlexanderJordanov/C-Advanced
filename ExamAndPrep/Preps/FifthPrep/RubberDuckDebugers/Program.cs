Queue<int> times = new Queue<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> numberOfTasks = new Stack<int>(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int darthVaderDucky = 0;
int thorDucky = 0;
int bigBlueRubberDucky = 0;
int smallYellowRubberDucky = 0;
while (numberOfTasks.Count > 0 && times.Count > 0)
{
    int time = times.Dequeue();
    int task = numberOfTasks.Peek();
    int result = time * task;
    if (result >= 0 && result <= 60)
    {
        numberOfTasks.Pop();
        darthVaderDucky++;
    }
    else if (result > 60 && result <= 120)
    {
        numberOfTasks.Pop();
        thorDucky++;
    }
    else if (result > 120 && result <= 180)
    {
        numberOfTasks.Pop();
        bigBlueRubberDucky++;
    }
    else if (result > 180 && result <= 240)
    {
        numberOfTasks.Pop();
        smallYellowRubberDucky++;
    }
    else if (result > 240)
    {
        times.Enqueue(time);
        task = numberOfTasks.Pop() - 2;
        numberOfTasks.Push(task);
    }
}
if (numberOfTasks.Count == 0)
{
    Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
}
Console.WriteLine($"Darth Vader Ducky: {darthVaderDucky}");
Console.WriteLine($"Thor Ducky: {thorDucky}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueRubberDucky}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellowRubberDucky}");