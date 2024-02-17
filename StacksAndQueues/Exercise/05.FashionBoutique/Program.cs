int[] clothesInBox = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rackCapacity = int.Parse(Console.ReadLine());

Stack<int> box = new Stack<int>(clothesInBox);

int sum = 0;
int racks = 1;

for (int i = 0; i < box.Count(); i++)
{
    if (sum + box.Peek() <= rackCapacity)
    {
        sum += box.Pop();
        i--;
    }
    else
    {
        sum = 0;
        racks++;
        i--;
    }
}

Console.WriteLine(racks);