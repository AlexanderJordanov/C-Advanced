int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(numbers);
List<int> evenNumbers = new List<int>();
while (queue.Count > 0)
{
    int number = queue.Dequeue();
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}
Console.WriteLine(string.Join(", ", evenNumbers.ToArray()));