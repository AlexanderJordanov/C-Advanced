string[] songs = Console.ReadLine()
    .Split(", ")
    .ToArray();

Queue<string> songsQueue = new Queue<string>(songs);

while (songsQueue.Count > 0)
{
    string[] commandArgs = Console.ReadLine()
        .Split()
        .ToArray();

    if (commandArgs[0] == "Play")
    {
        if (songsQueue.Any())
        {
            songsQueue.Dequeue();
        }
    }
    else if (commandArgs[0] == "Add")
    {
        string song = string.Join(" ",commandArgs.Skip(1));
        if (songsQueue.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songsQueue.Enqueue(song);
        }
    }
    else
    {
        Console.WriteLine(string.Join(", ", songsQueue));
    }
}
Console.WriteLine("No more songs!");